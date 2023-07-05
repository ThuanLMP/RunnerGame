using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public float moveSpeed = 5f;
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
        // float direcionY = Input.GetAxisRaw("Vertical");
        //playerDirection = new Vector2(0, 1).normalized;
    }

    void FixedUpdate()
    {
        //rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    public void MoveUp1()
    {
        playerDirection = new Vector2(0, 1).normalized;
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }


    public void MoveDown1()
    {
        playerDirection = new Vector2(0, -1).normalized;
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
