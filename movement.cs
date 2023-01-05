using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public Vector3 jump;
    public float jumpForce = 6.0f;
    public bool isGrounded = false;
    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                isGrounded = false;


            }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        // Update is called once per frame

    }
}
