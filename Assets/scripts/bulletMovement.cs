using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public float damage = 20f;

    Renderer rn;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        rn = GetComponent<Renderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "target")
        {
            enemy target = other.GetComponent<enemy>();
            target.takeDamage(damage);
            Destroy(gameObject);
        }
        else if (other.tag == "Player")
        {
            playerMovement target = other.GetComponent<playerMovement>();
            target.takeDamage(damage);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (!rn.isVisible)
        {
            Destroy(gameObject);
        }
    }

}
