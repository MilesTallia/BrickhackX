using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    Vector3 objectPosition = Vector3.zero;
    public Vector3 direction = Vector3.up;
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    float speed = 1;

    public float wrapXRight = 9f;
    public float wrapYUp = 5f;
    public float wrapXLeft = -9f;
    public float wrapYDown = -5f;

    public Vector3 Direction {
        set { direction = value.normalized;}
    }

    // Start is called before the first frame update
    void Start()
    {
        objectPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed * Time.deltaTime;

        objectPosition += velocity;

        transform.position = objectPosition;

        if (direction != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(Vector3.back,direction);
        }



        // WRAPPING
        if (objectPosition.x > wrapXRight) {
            objectPosition.x = wrapXLeft;
        }
        if (objectPosition.x < wrapXLeft) {
            objectPosition.x = wrapXRight;
        }
        if (objectPosition.y > wrapYUp) {
            objectPosition.y = wrapYDown;
        }
        if (objectPosition.y < wrapYDown) {
            objectPosition.y = wrapYUp;
        }
    }
}
