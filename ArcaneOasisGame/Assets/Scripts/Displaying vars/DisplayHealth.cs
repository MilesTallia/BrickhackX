using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    public PlayerHealth playerhealth;
    public Text health;

    void Start()
    {
        health.text = playerhealth.currentHealth.ToString();
    }

    void Update()
    {
        health.text = playerhealth.currentHealth.ToString();
    }
}
