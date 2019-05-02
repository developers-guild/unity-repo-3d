using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    const int STARTINGGOLD = 500;
    int currentGold;

    public PlayerInventory() {
        currentGold = STARTINGGOLD;
    }

    // Update is called once per frame
    public void Update()
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
