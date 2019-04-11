using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public const int STARTINGGOLD = 50;
    public int currentGold;
    public Text GoldAmount;
    public float timeSinceLastUpdate;
    private float timeSinceLastAdd;

    // Start is called before the first frame update
    void Start()
    {
        currentGold = STARTINGGOLD;
        timeSinceLastUpdate = Time.time;
        timeSinceLastAdd = 0;

    }

    // Update is called once per frame
    void Update()
    {

        //if(timeSinceLastUpdate > Time.fixedTime + 10f )
        //{
        //    currentGold += 1;
        //}

        timeSinceLastAdd += Time.deltaTime;

        if(timeSinceLastAdd > 1)
        {
            timeSinceLastAdd = 0;
            currentGold += 1;
        }




        GoldAmount.text = currentGold.ToString();
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
    public void getGold(int amount)
    {
        currentGold += amount;
    }

}
