using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Rigidbody2D rb;
    public Rigidbody2D player;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.velocity.x > 0)
        {
            rb.velocity = player.velocity;
        }
        else
        {
            rb.velocity = new Vector2(3, player.velocity.y);
        }
	}
}
