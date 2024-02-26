using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPlayer : MonoBehaviour
{
    private Transform player;
    public float z = 0;
    public float x_offset = 0;
    public float y_offset = 0;
    
    void Start (){
        player = GameObject.FindWithTag("Player").transform;
        x_offset = transform.position.x - player.transform.position.x;
        y_offset = transform.position.x - player.transform.position.y;
    }

    void Update () {
        transform.position = new Vector3 (player.position.x, player.position.y, z); 
    }

}
