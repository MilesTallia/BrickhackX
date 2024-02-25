using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollision : MonoBehaviour {

    public ResourcesManager resourcesManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag + " adding wood!");
        if (collision.tag == "Player") {
            resourcesManager.addWood(5);
            Destroy(this.gameObject);
        }
    }
    
}
