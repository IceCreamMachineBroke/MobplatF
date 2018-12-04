using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
