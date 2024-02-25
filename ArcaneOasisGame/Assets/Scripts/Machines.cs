using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Machines : MonoBehaviour
{
    public ResourcesManager resourceManager;
    private static int woodps;
    private static int stoneps;
    private static int metalps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resourceManager.addWood((int)(Time.deltaTime * (float)woodps));
        resourceManager.addStone((int)(Time.deltaTime * (float)stoneps));
        resourceManager.addMetal((int)(Time.deltaTime * (float)metalps));

    }

    //When the player upgrades a machine, this changes the value of the wood per second
    public void Upgrade(int type, int inc)
    {
        if (type == 1)
        {
            woodps += inc;
        }
        if (type == 2)
        {
            stoneps += inc;
        }
        if (type == 3)
        {
            metalps += inc;
        }

    }

    public void Levels(int type, int level)
    {
        Upgrade(type, level * 5);

    }

}
