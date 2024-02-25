using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    public PlayerHealth playerHealth;
    public PlayerHealth enemyHealth;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            Debug.Log("Hit player");
            playerHealth.TakeDamage(100);
            enemyHealth.TakeDamage(10);
        }
    }
}
