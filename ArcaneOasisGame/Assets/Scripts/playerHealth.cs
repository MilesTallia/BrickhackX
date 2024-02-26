using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int maxHealth = Wizard.getMaxHealth();
    public int currentHealth;

    public HealthBar healthBar;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update() {
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0) {
            transform.position = new Vector3(0,0, -1);
            currentHealth = maxHealth;
            healthBar.SetHealth(currentHealth);
        }
    }
}
