using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        jumpForce = 8f;

    }

    // Update is called once per frame
    void Update()
    {
        var axis = Input.GetAxis("Horizontal");
        transform.Translate(0, 0 , speed * axis * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
        }
    }

    bool isGrounded()
    {
        return GetComponent<Rigidbody>().velocity.y == 0;
    }
}

