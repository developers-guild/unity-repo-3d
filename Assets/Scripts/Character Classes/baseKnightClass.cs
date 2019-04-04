using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseKnightclass
///   Description:    This is the base Knight class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Garen from League of Legends
///-----------------------------------------------------------------------------------------------------------///

public class baseKnightClass : baseCharacterClass
{

    public baseKnightClass()
    {
        
        CharacterClassName = "Knight";
        CharacterClassDescription = "The noble and glorious characters whose main goal is defend the indefendable. They go on endless adventures in search for honor and glory.";



        ///-----------------///
        ///     BASE STATS
        ///----------------///
        playerHealth.startingHealth = 600;
        //Health = 616.28;
        HealthRegeneration = 8;
        Mana = 400;
        ManaRegeneration = 7.5;

        //      OFFENSE
        AttackDamage = 66;
        AttackSpeed = 0.625;
        AbilityPower = 0;
        PhysicalPenetration = 0;
        MagicPenetration = 0;

        //      DEFENSE
        PhysicalResistance = 36;
        MagicResistance = 32.1;
        LifeSteal = 0;
        SpellVamp = 0;
        Tenacity = 0;

        //      OTHER
        MovementSpeed = 340;
        Range = 175;
        CooldownReduction = 0;
    }
    
}
