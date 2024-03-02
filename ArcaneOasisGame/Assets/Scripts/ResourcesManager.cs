using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour {

    private static int woodAmount;
    private static int stoneAmount;
    private static int metalAmount;
    private static int gemAmount;
    private static int essenceAmount;

    public void addWood(int amount)
    {
        woodAmount += amount;
    }

    public void addStone(int amount)
    {
        stoneAmount += amount;
    }

    public void addMetal(int amount)
    {
        metalAmount += amount;
    }

    public void addGem(int amount)
    {
        gemAmount += amount;
    }

    public void addEssence(int amount)
    {
        essenceAmount += amount;
    }

    public int getWood()
    {
        return woodAmount;
    }

    public int getStone()
    {
        return stoneAmount;
    }

    public int getMetal()
    {
        return metalAmount;
    }

    public int getGem()
    {
        return gemAmount;
    }

    public int getEssence()
    {
        return essenceAmount;
    }
    
    void Start() {
        woodAmount = 0;
        stoneAmount = 0;
        metalAmount = 0;
        gemAmount = 0;
        essenceAmount = 0;
    }

    void Update() {
        
    }
}
