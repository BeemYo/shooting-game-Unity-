using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooter : MonoBehaviour
{

    public float shootRate;
    private float timeUntilShot;

    public Transform shootPoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilShot = shootRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUntilShot <= 0f)
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            timeUntilShot = shootRate;
        }
        else
        {
            timeUntilShot -= Time.deltaTime;
        }
    }
}
