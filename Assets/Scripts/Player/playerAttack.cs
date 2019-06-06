using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack
{
    baseCharacter baseChar;
    public playerAttack(baseCharacter baseChar)
    {
        this.baseChar = baseChar;
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            baseChar.basicAttack();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            baseChar.qAbility();
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
