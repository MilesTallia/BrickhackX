using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWood : MonoBehaviour {

    public ResourcesManager resourceManager;
    public Text wood;

    void Start() {
        wood.text = resourceManager.getWood().ToString();
    }

    void Update() {
        Debug.Log(resourceManager.getWood().ToString());
        wood.text = resourceManager.getWood().ToString();
    }
}
