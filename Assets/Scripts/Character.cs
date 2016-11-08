
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Character : MonoBehaviour
{

    const float DEADZONEHEIGHT = -3;
    private Vector3 startposition;
    private new Rigidbody2D rigidbody2D;
    public float max_Speed = 1;
    public float jumpforce;

    // Use this for initialization
    void Start()
    {
        startposition = transform.position;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var x_force = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity += Vector2.right * x_force;
        GetComponent<Rigidbody2D>().velocity = Vector2.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, max_Speed);

        if (Input.GetButtonDown("Jump") && rigidbody2D.velocity.y == 0)
        {
            rigidbody2D.velocity += Vector2.up * jumpforce;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            transform.localScale *= .5f;
        }

        if (transform.position.y < DEADZONEHEIGHT)
        {
            Die();
        }

        if (rigidbody2D.velocity.x > 0)
        {

            transform.rotation = new Quaternion(0, 0, 0, 0);

        }
        else if (rigidbody2D.velocity.x < 0)
        {

            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

    }
    public void Die()
    {
        transform.position = startposition;
        FindObjectOfType<Gamemanager>().lifewaslost();
        rigidbody2D.velocity = new Vector2();
    }


}
