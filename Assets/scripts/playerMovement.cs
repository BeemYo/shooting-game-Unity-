using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{

    public float speed = 12f;
    Vector2 direction;
    float rotate;
    Rigidbody2D rb;
    public float rotateSpeed = 200f;
    public float health = 100f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Vertical");
        direction.y = direction.x;
        rotate = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {

        rb.angularVelocity = -rotate * rotateSpeed;

        rb.MovePosition((Vector2)transform.position + (Vector2)transform.up * direction * speed * Time.deltaTime);
    }

    public void takeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}



