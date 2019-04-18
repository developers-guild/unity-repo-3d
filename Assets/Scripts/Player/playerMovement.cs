using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement
{
    public float speed;
    public float jumpForce;
    private bool isColliding = true;
    private Rigidbody rigidBody;

    public playerMovement(Rigidbody rigidbody)
    {
        this.rigidBody = rigidbody;
    }

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Start of player movement");
        speed = 5f;
        jumpForce = 8f;

    }

    // Update is called once per frame
    public void Update()
    {
        var axis = Input.GetAxis("Horizontal");
        rigidBody.transform.Translate(0, 0 , speed * axis * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            rigidBody.velocity = Vector3.up * jumpForce;
        }
    }

    bool isGrounded()
    {
        var floors = GameObject.FindGameObjectsWithTag("Floor");
        GameObject closestFloorUnder = floors[0];
        float closestDistanceFromFloor;

        for (int i = 1; i < floors.Length; i++)
        {
            float distanceFromFloor = rigidBody.transform.position.y - floors[i].transform.position.y;
            closestDistanceFromFloor = rigidBody.transform.position.y - closestFloorUnder.transform.position.y;
            if (distanceFromFloor > 0 && Mathf.Abs(distanceFromFloor) < Mathf.Abs(closestDistanceFromFloor) )
            {
                closestFloorUnder = floors[i];
            }
        }

        closestDistanceFromFloor = rigidBody.transform.position.y - closestFloorUnder.transform.position.y;
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

