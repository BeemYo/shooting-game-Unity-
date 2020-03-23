using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    private Transform player;
    public Rigidbody2D rb;
    private Vector2 desPos;
    private Quaternion desRot;

    public float speed = 12f;
    public float damage = 20f;
    public float health = 100f;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        desPos = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        rb.MovePosition(desPos);

        transform.rotation = desRot;

    }

    public void takeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerMovement player = other.GetComponent<playerMovement>();
            player.takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
