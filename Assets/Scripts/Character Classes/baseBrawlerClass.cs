using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseBrawlerClass
///   Description:    This is the base Brawler class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Vi from League of Legends
///-----------------------------------------------------------------------------------------------------------///

public class baseBrawlerClass : baseCharacterClass
{
    public baseBrawlerClass()
    {

        CharacterClassName = "Brawler";
        CharacterClassDescription = "With exceptional ability to beat and get beaten, these characters humble anyone in their sight. They are always ready for a fight.";


        ///-----------------///
        ///     BASE STATS
        ///----------------///

        Health = 585;
        HealthRegeneration = 10;
        Mana = 300;
        ManaRegeneration = 8;

        //      OFFENSE
        AttackDamage = 64;
        AttackSpeed = 0.644;
        AbilityPower = 0;
        PhysicalPenetration = 0;
        MagicPenetration = 0;

        //      DEFENSE
        PhysicalResistance = 32;
        MagicResistance = 32.1;
        LifeSteal = 0;
        SpellVamp = 0;
        Tenacity = 0;

        //      OTHER
        MovementSpeed = 340;
        Range = 125;
        CooldownReduction = 0;
    }
}
