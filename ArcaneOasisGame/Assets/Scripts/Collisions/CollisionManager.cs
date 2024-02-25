using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag);
        if (collision.tag == "Player") {
            Debug.Log("I got hit by the player!");
        }
    }
    
}
