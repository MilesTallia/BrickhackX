using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;





public class Machines : MonoBehaviour
{
    public ResourcesManager resourceManager;
    private static int woodps = 5;
    private static int stoneps = 5;
    private static int metalps = 5;
    List<Machine> machList = new List<Machine>();
    private static int maxMach;
    public TMP_Dropdown TMPDropdown;
    public TMP_Text text;

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

    public void addMachine(int type)
    {
        if(machList.Count < maxMach)
        {
            machList.Add(new Machine(type));

        }
    }

    public void UpMachine(Machine mach)
    {
        mach.AddLevel();
        Levels(mach.getType(), mach.getLevel());
    }
    public void AddMax()
    {
        if((resourceManager.getWood() > (Math.Pow(maxMach, 1.1) * 100) && (resourceManager.getStone() > (Math.Pow(maxMach, 1.1) * 100)))
            && (resourceManager.getMetal() > (Math.Pow(maxMach, 1.1) * 100))){
            maxMach++;
        }
    }

    public void dropBox()
    {
        TMPDropdown.options.Clear();
        foreach (Machine mach in machList)
        {
            TMPDropdown.options.Add(new TMP_Dropdown.OptionData() { text = mach.ToString() });
        }
    }

}
