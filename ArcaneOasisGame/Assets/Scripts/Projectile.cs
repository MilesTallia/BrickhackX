using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 4;
    public float timer = 5;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) {
            Destroy(gameObject);
        }
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
