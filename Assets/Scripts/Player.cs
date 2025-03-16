using UnityEngine;
using UnityEngine.Rendering.RenderGraphModule;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed, jumpForce; 
    [SerializeField] private Transform feet;
    [SerializeField] private LayerMask whatIsGround;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    private bool isGrounded, canDoubleJump;
    private float moveInput;

    private string weapon;
    private Vector2 spawnPoint;
    private int live;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        live=100;
        weapon="Daga";
    }

    void Update()
    {
        moveInput= Input.GetAxis("Horizontal");
        rb.linearVelocity= new Vector2( moveSpeed*moveInput, rb.linearVelocity.y);

        isGrounded=Physics2D.OverlapCircle(feet.position, 0.2f, whatIsGround);

        if(isGrounded){
            canDoubleJump=true;
        }

        if(Input.GetButtonDown("Jump")){
           if(isGrounded){
                rb.linearVelocity= new Vector2(rb.linearVelocity.x, jumpForce);
                anim.SetTrigger("Jump");

            }else{
                if(canDoubleJump){
                    rb.linearVelocity= new Vector2(rb.linearVelocity.x, jumpForce);
                    canDoubleJump=false;
                    anim.SetTrigger("Jump");
                }
            }
            
        }
        if(rb.linearVelocity.x<0){
            // spriteRenderer.flipX=true;
            anim.SetBool("Rigth", false);
        }
        else if(rb.linearVelocity.x>0){
            // spriteRenderer.flipX=false;
            anim.SetBool("Rigth", true);
        }

        
        anim.SetBool("Running", moveInput != 0);
        // anim.SetBool("IsGrounded", isGrounded);
    }

    void OTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("checkPoint")){
            spawnPoint=collision.transform.position;
        }
    }

    void Dead()
    {
        transform.position=spawnPoint;
    }

}
