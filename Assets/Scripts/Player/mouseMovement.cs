using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class mouseMovement : MonoBehaviour
{

    // Use this for initialization

    public Camera cam;
    public UnityEngine.AI.NavMeshAgent agent;
    public ThirdPersonCharacter character;

    void Start()
    {
        agent.updateRotation = false;
    }


    // Update is called once per frame
    void Update()
    {

        // When user clicks mouseleft button
        if (Input.GetMouseButtonDown(0))
        {
            // Trace position using camera Ray 
            // The ray basically sennds a line from the camera to the mouse click
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // The hit stores the coordinate i
            RaycastHit hit;
            // did the mouse 
            if (Physics.Raycast(ray, out hit))
            {
                //move player
                agent.SetDestination(hit.point);
            }

        }
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            // vector 0 means no speed
            character.Move(Vector3.zero, false, false);
        }

    }
}
