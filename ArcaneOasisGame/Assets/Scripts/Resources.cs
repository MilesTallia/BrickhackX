using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Resources {
    private static int woodAmount;
    private static int stoneAmount;
    private static int metalAmount;
    private static int gemAmount;
    private static int essenceAmount;

    public static void addWood(int amount)
    {
        woodAmount += amount;
    }

    public static void addStone(int amount)
    {
        stoneAmount += amount;
    }

    public static void addMetal(int amount)
    {
        metalAmount += amount;
    }

    public static void addGem(int amount)
    {
        gemAmount += amount;
    }

    public static void addEssence(int amount)
    {
        essenceAmount += amount;
    }

    public static int getWood()
    {
        return woodAmount;
    }

    public static int getStone()
    {
        return stoneAmount;
    }

    public static int getMetal()
    {
        return metalAmount;
    }

    public static int getGem()
    {
        return gemAmount;
    }

    public static int getEssence()
    {
        return essenceAmount;
    }


}

