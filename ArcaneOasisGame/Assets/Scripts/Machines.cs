using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Machines : MonoBehaviour
{
    public ResourcesManager resourceManager;
    private static int woodps = 5;
    private static int stoneps = 5;
    private static int metalps = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float interval = 0;
        interval += Time.deltaTime;
        if (interval > 1)
        {
            resourceManager.addWood(woodps);
            resourceManager.addStone(stoneps);
            resourceManager.addMetal(metalps);
            interval = 0;
        }

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
