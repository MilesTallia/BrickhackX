using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStone : MonoBehaviour
{
    public ResourcesManager resourceManager;
    public Text stone;

    void Start()
    {
        stone.text = resourceManager.getStone().ToString();
    }

    void Update()
    {
        stone.text = resourceManager.getStone().ToString();
    }
}