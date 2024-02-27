using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {
    public EnemyHealth enemyHealth;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag);
        if (collision.tag == "Player") {
            Debug.Log("Hit player");
            enemyHealth.TakeDamage(10);
        }
        if (collision.tag == "Attack") {
            Debug.Log("got hit");
            enemyHealth.TakeDamage(30);
        }
    }
}
