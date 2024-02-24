using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    // puts attack on cooldown
    private float attackCooldown = 0;
    // how long the attack has been going on for
    private float attackTimer = 0;
    //how much damage the attack does
    public float attackDistance;
    //how long the enemy readies attack for
    private float readyTime = 2;

    //locks a direction
    private Vector3 playerDirection;

    //how much distance the enemy has moved.
    private float distanceMoved;
    //detects if the player is in range
    public EnemyDetect detector;

    private bool isAttacking;

    public SpriteRenderer spriteRenderer;
    public Sprite readySprite;

    public Sprite restSprite;

    public Sprite attackSprite;
    // Start is called before the first frame update

    public float attackSpeed;

    private Vector3 velocity;
    
    void Start()
    {
        
    }

    void setRestSprite(){
        spriteRenderer.sprite = restSprite;
    }

    void setReadySprite(){
        spriteRenderer.sprite = restSprite;
    }

    void setAttackSprite(){
        spriteRenderer.sprite = restSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackCooldown > 0) {
            attackCooldown -= Time.deltaTime;
        }
        else{
            if (isAttacking){
                attackTimer += Time.deltaTime;
                if (attackTimer > readyTime) {
                    if (distanceMoved > attackDistance){
                        isAttacking = false;
                        attackCooldown = 4;
                        setRestSprite();
                    } else {
                        setAttackSprite();
                        velocity = playerDirection * attackSpeed * Time.deltaTime;
                        transform.position += velocity;
                        distanceMoved += velocity.magnitude;
                    }
                }
            }
            else if (detector.playerInRange) {
                playerDirection = (transform.position - detector.player.position).normalized;
                distanceMoved = 0;
                attackTimer = 0;
                isAttacking = true;
                setReadySprite();
            }

        }
    }
}
