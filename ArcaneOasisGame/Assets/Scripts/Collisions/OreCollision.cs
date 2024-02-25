using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreCollision : MonoBehaviour {

    public ResourcesManager resourcesManager;

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.tag + " adding ore!");
        if (collision.tag == "Player") {
            resourcesManager.addMetal(5);
            resourcesManager.addGem(3);
        }
    }
    
}
