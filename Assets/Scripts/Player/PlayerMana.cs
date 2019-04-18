using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    public int startingMana = 100;                      
    public int currentMana;                              
    public Slider ManaSlider;

    public float timeSinceLastUpdate;
    private float timeSinceLastAdd;



    // Start is called before the first frame update
    void Start()
    {
        currentMana = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastAdd += Time.deltaTime;

        if (timeSinceLastAdd > 1)
        {
            timeSinceLastAdd = 0;
            if(currentMana < startingMana)
            {
                currentMana += 5;
            }
            else if(currentMana > startingMana)
            {
                currentMana -= 5;
            }
            ManaSlider.value = currentMana;
        }
    }

    bool useMana(int amount)
    {
        if((currentMana - amount) >= 0)
        {
            currentMana -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    void addMana(int amount)
    {
        if((currentMana += amount) < int.MaxValue)
        {
            currentMana += amount;
        }
    }
}
