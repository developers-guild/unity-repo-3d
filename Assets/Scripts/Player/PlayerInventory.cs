using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    const int STARTINGGOLD = 500;
    int currentGold;
    // Start is called before the first frame update
    void Start()
    {
        currentGold = STARTINGGOLD;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGoldChanged()
    {
        //text.text = "Gold: " + currentGold.ToString();
    }

    public void loseGold(int amount)
    {
        currentGold -= amount;
        if(amount < 0)
        {
            amount = 0;
        }
    }

}
