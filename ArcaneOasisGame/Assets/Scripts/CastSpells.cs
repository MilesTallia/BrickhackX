using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpells : MonoBehaviour
{

    public GameObject spell1;
    public float spell1Cooldown;
    private float spell1Timer = 0;

    public GameObject spell2;
    public float spell2Cooldown;
    private float spell2Timer = 0;
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public float getSpellTimer1()
    {
        return spell1Timer;
    }

    public float getSpellTimer2()
    {
        return spell2Timer;
    }

    void Start()
    {
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

        if(spell2Timer <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                float dir = Vector2.SignedAngle(Vector2.right, rb.velocity.normalized)-90;
                if (rb.velocity.normalized == Vector2.zero){
                    Instantiate(spell2, transform.position + Vector3.right, Quaternion.Euler(new Vector3(0, 0, dir)), this.transform);
                }
                else {
                    Instantiate(spell2, transform.position + new Vector3(rb.velocity.normalized.x,rb.velocity.normalized.y , 0), Quaternion.Euler(new Vector3(0, 0, dir)), this.transform);
                } 
                spell2Timer = spell2Cooldown;
            }
        }
        else
        {
            spell2Timer -= Time.deltaTime;
        }
    }
}
