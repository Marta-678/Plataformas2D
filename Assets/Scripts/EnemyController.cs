using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed, moveTime, waitTime;
    private float moveCount, waitCount;
    public Transform leftPoint, rigthPoint;

    private bool movingRight;
    private SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        leftPoint.parent= null;
        rigthPoint.parent= null;
        spriteRenderer=GetComponent<SpriteRenderer>();

        moveCount=moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveCount>0){
            if(movingRight){
            rb.linearVelocity= new Vector2(moveSpeed, rb.linearVelocity.y);
            spriteRenderer.flipX= true;

            if(transform.position.x > rigthPoint.position.x){
                movingRight= false;
            }
        }else{
            rb.linearVelocity= new Vector2(-moveSpeed, rb.linearVelocity.y);
            spriteRenderer.flipX=false;

            if(transform.position.x < leftPoint.position.x){
                movingRight= true;
            }
        }
        }
    }
}
