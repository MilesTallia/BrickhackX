using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour{
    public int maxHealth = 200;
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
            Destroy(gameObject);
        }
    }
}
