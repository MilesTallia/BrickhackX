using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour {
    public PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Enemy") {
            Debug.Log("Hit enemy");
            playerHealth.TakeDamage(40);
        }
        if (collision.tag == "Base")
        {
            Debug.Log("Hit Base");
            SceneManager.LoadScene("Tower");
        }
    }
}
