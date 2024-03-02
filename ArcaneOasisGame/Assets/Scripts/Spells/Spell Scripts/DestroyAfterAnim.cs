using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterAnim : MonoBehaviour {
    public float delay = 0;
    
    void Start() {
        float animTime = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        Destroy(gameObject, animTime);
    }
}