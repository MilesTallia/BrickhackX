using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEssence : MonoBehaviour
{
    public ResourcesManager resourceManager;
    public Text essence;

    void Start()
    {
        essence.text = resourceManager.getEssence().ToString();
    }

    void Update()
    {
        essence.text = resourceManager.getEssence().ToString();
    }
}
