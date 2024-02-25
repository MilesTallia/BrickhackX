using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DestroyAfterAnim : MonoBehaviour {
    public float delay = 0;
    
    void Start() {
        float animTime = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;
        Debug.Log(animTime);
        Destroy(gameObject, animTime);
    }
}
