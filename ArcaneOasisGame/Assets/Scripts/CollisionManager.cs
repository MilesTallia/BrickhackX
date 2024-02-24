using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
    [SerializeField]
    
    List<SpriteInfo> sprites = new List<SpriteInfo>();

    public Toggle AABBOrCircle;

    public bool collision = false;

    void Start(){
        
    }

    void Update(){
        for (int i = 1; i < sprites.Count; i++) {
            if (AABBOrCircle.isOn) {
                if (AABBCollisionCheck(sprites[0],sprites[i])) {
                    collision = true;
                    sprites[0].spriteRenderer.color = Color.red;
                    sprites[i].spriteRenderer.color = Color.red;
                    return;
                }
            } else {
                if (CircleCollisionCheck(sprites[0],sprites[i])) {
                    collision = true;
                    sprites[0].spriteRenderer.color = Color.red;
                    sprites[i].spriteRenderer.color = Color.red;
                    return;
                }
            }
        }
        for (int i = 0; i < sprites.Count; i++) {
            sprites[i].spriteRenderer.color = Color.white;   
        }
        collision = false;
    }

    bool AABBCollisionCheck(SpriteInfo a, SpriteInfo b) {
        if (
            a.min.x < b.max.x &
            a.max.x > b.min.x &
            a.min.y < b.max.y &
            a.max.y > b.min.y 
        ) {
            return true;
        }
        return false;
    }

    bool CircleCollisionCheck(SpriteInfo a, SpriteInfo b) {
        if (a.radius+b.radius > Vector3.Distance(a.location,b.location)) {
            return true;
        }
        return false;
    }
}
