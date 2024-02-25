using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Wizard {
    private static int maxHealth;
    private static int currHealth;
    private static int attack;
    private static int critChance;
    private static int critDamage;
    private static int numWeapons;
    private static string[] weapons = {"", "", ""};


    public static int getMaxHealth()
    {
        return maxHealth;
    }

    public static int getCurrHealth()
    {
        return currHealth;
    }

    public static int getAttack()
    {
        return attack;
    }

    public static int getCritChance()
    {
        return critChance;
    }

    public static int getCritDamage()
    {
        return critDamage;
    }


    public static void addMaxHealth(int amount)
    {
        maxHealth += amount;
    }

    public static void addCurrHealth(int amount)
    {
        currHealth += amount;
    }

    public static void addAttack(int amount)
    {
        attack += amount;
    }

    public static void addCritChance(int amount)
    {
        critChance += amount;
    }

    public static void addCritDamage(int amount)
    {
        critDamage += amount;
    }

    public static void addnumWeapons()
    {
        if (numWeapons < 3){
            numWeapons++;
        }
    }

    public static void subMaxHealth(int amount)
    {
        maxHealth -= amount;
    }

    public static void subCurrHealth(int amount)
    {
        currHealth -= amount;
    }

    public static void subAttack(int amount)
    {
        attack -= amount;
    }

    public static void subCritChance(int amount)
    {
        critChance -= amount;
    }

    public static void subCritDamage(int amount)
    {
        critDamage -= amount;
    }

    public static void changeWeapons(int pos, string weapon)
    {
        weapons[pos] = weapon;
    }
 
}
