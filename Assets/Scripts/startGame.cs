using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startGame : MonoBehaviour
{
    public GameObject[] players;

    private Button mButton;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var player in players)
        {
            player.SetActive(false);
        }

        // Add the OnClick event to the button.
        mButton = GetComponent<Button>();
        mButton.onClick.AddListener(EnablePlayers);
    }

    void Update()
    {
        //if left click is pressed,
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray;
            RaycastHit hit;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                var baseTurret = GameObject.Find("Turret");

                var turret = Object.Instantiate(baseTurret);
                //var turret = new defaultTurret();
                //turret.CreateAt(new Vector3(hit.point.x, hit.point.y + 10, hit.point.z));
                turret.transform.position = hit.point;
                turret.name = $"{name}_Turret{Time.time}";
            }
        }
    }

    void EnablePlayers()
    {
        foreach(var player in players)
        {
            player.SetActive(true);
        }

        // Disable the start button.
        gameObject.SetActive(false);

    }



}
