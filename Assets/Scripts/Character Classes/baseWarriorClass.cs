using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseWarriorclass
///   Description:    This is the base Warrior class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Garen from League of Legends
///-----------------------------------------------------------------------------------------------------------///


//ClassEnum currentClass { get; set; }

//// Player Components
//PlayerHealth playerHealth { get; set; }

//// Player Fields
//string characterClassDescription { get; set; }

//// Player Methods
//void basicAttack(RaycastHit target);
//void qAbility();
//void eAbility();
//void fAbility();
//void leftShiftAbility();

public class baseWarriorClass : MonoBehaviour, baseCharacter
{
    public ClassEnum currentClass { get => ClassEnum.Warrior; }
    public PlayerHealth playerHealth { get; set; }
    public playerAttack playerAttack { get; set; }
    public playerMovement playerMovement { get; set; }
    public PlayerInventory playerInventory { get; set; }

    // Create class to hold Player Info/Lore and have it in one big enum
    public string characterClassDescription { get => "The noble and glorious characters whose main goal is defend the indefendable. They go on endless adventures in search for honor and glory."; }
    public baseWarriorClass()
    {

        // Make constructor to initialize playerHealth
        playerHealth = new PlayerHealth();
        playerHealth.startingHealth = 600;

        playerAttack = new playerAttack();
        playerMovement = new playerMovement(GetComponent<Rigidbody>());
        playerInventory = new PlayerInventory();


        ///-----------------///
        ///     BASE STATS
        ///----------------///
        //Health = 616.28;
        //HealthRegeneration = 8;
        //Mana = 400;
        //ManaRegeneration = 7.5;

        ////      OFFENSE
        //AttackDamage = 66;
        //AttackSpeed = 0.625;
        //AbilityPower = 0;
        //PhysicalPenetration = 0;
        //MagicPenetration = 0;

        ////      DEFENSE
        //PhysicalResistance = 36;
        //MagicResistance = 32.1;
        //LifeSteal = 0;
        //SpellVamp = 0;
        //Tenacity = 0;

        ////      OTHER
        //MovementSpeed = 340;
        //Range = 175;
        //CooldownReduction = 0;
    }

    public void basicAttack(RaycastHit target)
    {
        // Swing sword towards click, if an enemy is in range, takes damage

        Debug.Log("wahoo clicked");
    }

    public void eAbility()
    {
        throw new System.NotImplementedException();
    }

    public void fAbility()
    {
        throw new System.NotImplementedException();
    }

    public void leftShiftAbility()
    {
        throw new System.NotImplementedException();
    }

    public void qAbility()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        Debug.Log("wahhooo1231231");
        playerHealth.Update();
        playerInventory.Update();
        playerMovement.FixedUpdate();
        playerAttack.Update();
    }
}
