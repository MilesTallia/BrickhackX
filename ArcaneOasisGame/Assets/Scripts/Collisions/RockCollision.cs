using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour {

    public ResourcesManager resourcesManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag + " adding stone!");
        if (collision.tag == "Player") {
            resourcesManager.addStone(5);
            resourcesManager.addGem(1);
        }
    }
    
}
