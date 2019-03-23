using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseMageClass
///   Description:    This is the base Mage class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Ziggs from League of Legends
///-----------------------------------------------------------------------------------------------------------///

public class baseMageClass : baseCharacterClass
{
    public baseMageClass()
    {

        CharacterClassName = "Mage";
        CharacterClassDescription = "Hungry for power, driven by ambition. These characters have talents that are unheard of.";


        ///-----------------///
        ///     BASE STATS
        ///----------------///

        Health = 530;
        HealthRegeneration = 6.5;
        Mana = 480;
        ManaRegeneration = 8.5;

        //      OFFENSE
        AttackDamage = 54;
        AttackSpeed = 0.656;
        AbilityPower = 60;
        PhysicalPenetration = 0;
        MagicPenetration = 0;

        //      DEFENSE
        PhysicalResistance = 21.544;
        MagicResistance = 30;
        LifeSteal = 0;
        SpellVamp = 0;
        Tenacity = 0;

        //      OTHER
        MovementSpeed = 325;
        Range = 550;
        CooldownReduction = 0;
    }
}
