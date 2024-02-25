using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGem : MonoBehaviour
{
    public ResourcesManager resourceManager;
    public Text gem;

    void Start()
    {
        gem.text = resourceManager.getGem().ToString();
    }

    void Update()
    {
        gem.text = resourceManager.getGem().ToString();
    }
}
