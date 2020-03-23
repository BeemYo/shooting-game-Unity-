using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    private Vector2 pos;
    public float startTimeBtwSpwn = 2f;
    private float timeBtwSpwn;

    void Start()
    {
        pos.x = pos.y = 0f;
    }

    void Update()
    {
        if (timeBtwSpwn <= 0)
        {
            Instantiate(enemy, pos, Quaternion.identity);
            timeBtwSpwn = startTimeBtwSpwn;
        }
        else
        {
            timeBtwSpwn -= Time.deltaTime;
        }
    }
}
