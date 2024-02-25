using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpells : MonoBehaviour
{

    public GameObject spell1;
    public float spell1Cooldown;

    private float spell1Timer = 0;
    // Start is called before the first frame update

    private Vector3 prevPosition;

    private Rigidbody2D rb;

    void Start()
    {
        prevPosition = transform.position;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(spell1Timer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(spell1, transform.position, Quaternion.Euler(new Vector3(0, 0, Vector2.SignedAngle(Vector2.right, rb.velocity.normalized))));
                spell1Timer = spell1Cooldown;
            }
        }
        else
        {
            spell1Timer -= Time.deltaTime;
        }
        prevPosition = transform.position;
    }
}
