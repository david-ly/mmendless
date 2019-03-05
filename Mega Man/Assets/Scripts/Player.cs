using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public LayerMask whatIsGround;
    private bool onGround;
    private bool wallJump;
    public GameObject platform;
    float endStart;
    bool dashing;
    bool airDash;
    float dashTime = 0.33f;
    private Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(3, rb.velocity.y);
        rb.gravityScale = 1;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (dashing)
        {
            dashTime -= Time.deltaTime;
            if (dashTime <= 0)
            {
                dashing = false;
                dashTime = 0.33f;
            }
        }
        else
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
            rb.gravityScale = 1;
        } 
        onGround = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y - 1), whatIsGround);
        wallJump = Physics2D.OverlapPoint(new Vector2(transform.position.x + .5f, transform.position.y), whatIsGround);
        if (onGround || wallJump)
        {
            airDash = false;
        }
        if (wallJump)
        {
            rb.gravityScale = 0.8f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && wallJump)
        {
            rb.velocity = new Vector2(-7.5f, 4);
        }
        else if (Input.GetKey(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && !dashing && !airDash)
        {
            dashing = true;
            airDash = true;
            rb.gravityScale = 0;
            rb.velocity = new Vector2(rb.velocity.x * 2, 0);
        }
        if (rb.velocity.x > 3 && rb.velocity.y == 0)
        {
            anim.SetBool("Dashing", true);
        } else
        {
            anim.SetBool("Dashing", false);
        }
        if (rb.velocity.y >= 0 && !onGround && rb.velocity.x <= 3)
        {
            anim.SetBool("Jumping", true);
        } else
        {
            anim.SetBool("Jumping", false);
        }
        if (rb.velocity.y <= 0 && !onGround && rb.velocity.x <= 3)
        {
            anim.SetBool("Falling", true);
        } else
        {
            anim.SetBool("Falling", false);
        }
    }
}
