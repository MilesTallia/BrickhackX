using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells : MonoBehaviour {
    public static float fireballCD;
    public static float knifeCD;
    public static float auraInterval;

    void Start() {
        fireballCD = 5;
        knifeCD = 0.5F;
        auraInterval = 1;

    }

    void Update() {
        if(fireballCD > 0) {
            fireballCD -= Time.deltaTime;
        }
        if(knifeCD > 0) {
            knifeCD -= Time.deltaTime;
        }
        if(auraInterval > 0) {
            auraInterval -= Time.deltaTime;
        }
    }

    public void useFireball() { fireballCD = 0; }
    public void useKnife() { knifeCD = 0; }
    public void useAura() { auraInterval = 0; }

}
