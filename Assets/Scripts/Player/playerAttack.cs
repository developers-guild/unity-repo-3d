using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                string tag = hit.transform.tag;
                if(tag == "RedTeam")
                {
                    Debug.Log("Clicked on an enemy: " + hit.transform.name);
                    GetComponent<baseCharacter>().basicAttack(hit);
                    //hit.transform.GetComponent<PlayerHealth>().TakeDamage(10);    //Get which player is clicking who ex: Call Warriorclass.BasicAttack(target)
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

        }

        if (Input.GetKeyDown(KeyCode.E))
        {

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

        }

        if (Input.GetKeyDown(KeyCode.F))
        {

        }
    }
}
