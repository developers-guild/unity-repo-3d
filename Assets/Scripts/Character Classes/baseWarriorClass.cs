using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseWarriorclass
///   Description:    This is the base Warrior class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Garen from League of Legends
///   Wiki Page:      https://github.com/developers-guild/unity-repo-3d/wiki/Warrior
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

public class baseWarriorClass : baseCharacter
{
    const int MAX_HEALTH = 600;
    const int RANGE = 10;

    const int BASE_DAMAGE = 15;

    public ClassEnum currentClass { get => ClassEnum.Warrior; }
    public PlayerHealth playerHealth { get; set; }
    public playerAttack playerAttack { get; set; }
    public playerMovement playerMovement { get; set; }
    public PlayerInventory playerInventory { get; set; }
    private PlayerMaster parentClass { get; set; }


    private Rigidbody rigidBody;

    // Create class to hold Player Info/Lore and have it in one big enum
    public string characterClassDescription { get => "The noble and glorious characters whose main goal is defend the indefendable. They go on endless adventures in search for honor and glory."; }
    public baseWarriorClass()
    {
        
    }

    public baseWarriorClass(Rigidbody playerRb, PlayerMaster parent)
    {
        // Make constructor to initialize playerHealth
        playerHealth = new PlayerHealth(playerRb, MAX_HEALTH);

        playerAttack = new playerAttack(this);

        playerMovement = new playerMovement(playerRb);

        playerInventory = new PlayerInventory();

        rigidBody = playerRb;
        parentClass = parent;
    }

    public void basicAttack()
    {
        // Swing sword towards click, if an enemy is in range, takes damage
        Vector3 offset = rigidBody.transform.up * (rigidBody.transform.localScale.y / 2f) * -1f;
        Vector3 playerPos = rigidBody.transform.position + offset;

        if (playerMovement.isFacingLeft)
        {
            Vector3 maxHitPos = new Vector3(playerPos.x, playerPos.y, playerPos.z - RANGE);

            GameObject[] oppositeTeamObjects = parentClass.oppositeTeamObjects;
            foreach (GameObject g in oppositeTeamObjects)
            {
                if (g.transform.position.z < playerPos.z && g.transform.position.z > maxHitPos.z)
                {
                    g.GetComponent<PlayerMaster>().baseClass.playerHealth.TakeDamage(BASE_DAMAGE);
                    Debug.Log("Hit target while facing left, new health is: " + g.GetComponent<PlayerMaster>().getCurrentHealth());
                    
                }
            }
        }
        else
        {
            Vector3 maxHitPos = new Vector3(playerPos.x, playerPos.y, playerPos.z + RANGE);

            GameObject[] oppositeTeamObjects = parentClass.oppositeTeamObjects;
            foreach (GameObject g in oppositeTeamObjects)
            {
                if (g.transform.position.z > playerPos.z && g.transform.position.z < maxHitPos.z)
                {
                    g.GetComponent<PlayerMaster>().baseClass.playerHealth.TakeDamage(BASE_DAMAGE);
                    Debug.Log("Hit target while facing right, new health is: " + g.GetComponent<PlayerMaster>().getCurrentHealth());
                }
            }
        }
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
        Debug.Log("Warrior Q Ability");
    }

    public void Update()
    {
        playerHealth.Update();
        playerInventory.Update();
        playerMovement.Update();
        playerAttack.Update();
    }
}
