using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpell : Spell
{

    public override void castSpell(float dir){
        // Instantiate(spell2, transform.position + new Vector3(rb.velocity.normalized.x,rb.velocity.normalized.y , 0), Quaternion.Euler(new Vector3(0, 0, dir)), this.transform);
        timer = cd;
    }
}


