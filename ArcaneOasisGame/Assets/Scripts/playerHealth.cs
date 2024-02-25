using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = Wizard.getMaxHealth();
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        //when taking damage call "TakeDamage(damage number dealt)"
        //TakeDamage(1);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0) {
            transform.position = new Vector3(0,0, -1);
            currentHealth = maxHealth;
            healthBar.SetHealth(currentHealth);
        }
    }
}
