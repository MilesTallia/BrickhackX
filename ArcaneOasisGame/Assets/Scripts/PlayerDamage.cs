using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Enemy") {
            Debug.Log("Hit enemy");
            playerHealth.TakeDamage(40);
        }
    }
}
