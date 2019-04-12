using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private bool isColliding = true;
    private Rigidbody collider;

    public playerMovement(Rigidbody rigidbody)
    {
        this.collider = rigidbody;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("boo");
        speed = 5f;
        jumpForce = 8f;

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        var rigidBody = GetComponent<Rigidbody>();
        var axis = Input.GetAxis("Horizontal");
        transform.Translate(0, 0 , speed * axis * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
        }
    }

    bool isGrounded()
    {
        var rigidBody = GetComponent<Rigidbody>();

        var floors = GameObject.FindGameObjectsWithTag("Floor");
        GameObject closestFloorUnder = floors[0];
        float closestDistanceFromFloor;

        for (int i = 1; i < floors.Length; i++)
        {
            float distanceFromFloor = transform.position.y - floors[i].transform.position.y;
            closestDistanceFromFloor = transform.position.y - closestFloorUnder.transform.position.y;
            if (distanceFromFloor > 0 && Mathf.Abs(distanceFromFloor) < Mathf.Abs(closestDistanceFromFloor) )
            {
                closestFloorUnder = floors[i];
            }
        }

        closestDistanceFromFloor = transform.position.y - closestFloorUnder.transform.position.y;
        return closestDistanceFromFloor < 0.7 && rigidBody.velocity.y == 0;
    }

    void OnCollisionEnter()
    {
        isColliding = true;
    }

    void OnCollisionExit()
    {
        isColliding = false;
    }
}

