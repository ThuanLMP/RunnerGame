using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRun", true);
    }

    // Update is called once per frame
    void Update()
    {
        float direcionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, direcionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
