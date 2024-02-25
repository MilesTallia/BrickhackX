using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWood : MonoBehaviour
{
    public Text wood;
    // Start is called before the first frame update
    void Start()
    {
        wood.text = Resources.getWood().ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
