using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

    //how long before next cast
    protected float timer = 0;

    //how long between casts
    public float cd;

    //the projectile
    public GameObject projectiles;
    //spell image
    public Sprite sprite;

    public string title;
    //how long till the next cast
    public float getTimer() {
        return timer;
    }

    //how long between every cast
    public float getCoolDown(){
        return cd;
    }

    public abstract void castSpell(float dir);
    
    public string getName() {
        return title;
    }

    public Sprite getSprite(){
        return sprite;
    }

    void Update() {
        if (!(timer <= 0)){
            timer -= Time.deltaTime;
        }
    }
}
