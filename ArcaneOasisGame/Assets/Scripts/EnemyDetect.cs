using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetect : MonoBehaviour {

    public Transform player;
    public bool playerInRange;
    private string detectionTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision) {
       if (collision.gameObject.CompareTag(detectionTag)) {
           playerInRange = true;
           player = collision.gameObject.transform;
       }
    }

    private void OnTriggerExit2D(Collider2D collision) {
       if (collision.gameObject.CompareTag(detectionTag))
       {
           playerInRange = false;
           player = null;
       }
    }
}
