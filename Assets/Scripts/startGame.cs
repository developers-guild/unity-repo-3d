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
