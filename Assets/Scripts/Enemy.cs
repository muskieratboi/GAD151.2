﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]//Makes Enemy stats viewable in the Unity Editor.
/// <summary>
/// Contains basic Enemy info.
/// </summary>
public class Enemy
{

    /// <summary>
    /// The Enemy's name.
    /// </summary>
    public string name;

    /// <summary>
    /// The Enemy's Current health.
    /// </summary>
    public int health;

    /// <summary>
    /// The Enemy's total Damage output.
    /// </summary>
    public int damage;

    /// <summary>
    /// The name of the item the Enemy is Carrying.
    /// </summary>
    public string item;

    /// <summary>
    /// The amount of GP the enemy is carrying.
    /// </summary>
    public int gold;

    public Sprite enemySprite;

    public int experience;

    /// <summary>
    /// Default Constructor for the <see cref="Enemy"/> class.
    // /// </summary>
    // public Enemy()
    // {		
    //     name = "Slime";
    //     health = 5;
    //     damage = 5;
    //     item = "Slime Goo";
    //     gold = 10;
    //     experience = 5;
    //     enemySprite = null;
    // }

    /// <summary>
    /// Custom constructor for the <see cref="Enemy"/> class.
    /// </summary>
    public Enemy(string nameIN, int healthIN, int damageIN, string itemIN, int goldIN, Sprite spriteIN, int expIN)
    {
        //set custom attributes
        name = nameIN;
        health = healthIN;
        damage = damageIN;
        item = itemIN;
        gold = goldIN;
        enemySprite = spriteIN;
        experience = expIN;
    }

    // Copy constructor
    public Enemy(Enemy enemyIN)
    {
        name = enemyIN.name;
        health = enemyIN.health;
        damage = enemyIN.damage;
        item = enemyIN.item;
        gold = enemyIN.gold;
        enemySprite = enemyIN.enemySprite;
        experience = enemyIN.experience;
    }

    /// <summary>
    /// Prints a message declaring combat has begun to the Debug Log.
    /// </summary>
    public void Encounter(BattleLogController battleLog)
    {
        //Print to the battle Log
        battleLog.AddText("A " + name + " draws near!");
    }

    /// <summary>
    /// Attack the specified player instance.
    /// </summary>
    /// <param name="playerInst">player instance to attack.</param>
    /// <param name="battleLog">The battleLogController (to display text)</param>
    public void Attack(Player playerInst, BattleLogController battleLog)
    {
        //use Mathf.Max to make sure the player's Health doesn't fall below 0	
        playerInst.health = Mathf.Max(0, playerInst.health - damage);
        battleLog.AddText(name + " Hits " + playerInst.name + " for " + damage + " damage!");
    }
}
