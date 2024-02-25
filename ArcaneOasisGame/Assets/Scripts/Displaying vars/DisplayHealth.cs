using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    public ResourcesManager resourceManager;
    public Text health;

    void Start()
    {
        health.text = resourceManager.getMetal().ToString();
    }

    void Update()
    {
        health.text = resourceManager.getMetal().ToString();
    }
}
