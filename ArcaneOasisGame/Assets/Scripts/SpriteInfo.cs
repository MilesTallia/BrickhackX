using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteInfo : MonoBehaviour
{

    public Vector3 min, max;

    public Vector3 location;
    public float radius;

    public SpriteRenderer spriteRenderer;

    void Start() {

        spriteRenderer = GetComponent<SpriteRenderer>();

        min = spriteRenderer.bounds.min;
        max = spriteRenderer.bounds.max;
        
        location = spriteRenderer.bounds.center;
        radius = spriteRenderer.bounds.extents.x;
        
    }

    void Update() {
        min = spriteRenderer.bounds.min;
        max = spriteRenderer.bounds.max;
        location = spriteRenderer.bounds.center;
    }

    private void onDrawGizmosSelected() {

        Gizmos.color = Color.green;
        if (spriteRenderer != null) {
            Gizmos.DrawWireCube(transform.position, spriteRenderer.bounds.size);
        }
        
        Gizmos.color = Color.blue;
        if (spriteRenderer != null) {
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}
