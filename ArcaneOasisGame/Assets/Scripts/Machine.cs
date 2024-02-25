using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine{

    private static int level;
    private static int type;


    public Machine(int whichType){
        type = whichType;
        level = 1;
    }

    public void AddLevel()
    {
        level++;
    }

    public int getLevel()
    {
        return level;
    }

    public int getType()
    {
        return type;
    }

}
