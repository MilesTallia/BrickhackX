using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMetal : MonoBehaviour
{
    public ResourcesManager resourceManager;
    public Text metal;

    void Start()
    {
        metal.text = resourceManager.getMetal().ToString();
    }

    void Update()
    {
        metal.text = resourceManager.getMetal().ToString();
    }
}