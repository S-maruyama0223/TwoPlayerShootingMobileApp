using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public FloatingJoystick joystick;
    public GroundCheck groundCheck;
    private float moveSpeed = 10;
    private Rigidbody2D rb;
    // ジャンプ力
    private float flap = 1500.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float y = joystick.Vertical;

        if (x < 0)
        {
            // 左向き
            transform.localScale = new Vector3(-1, 1, 1);
        } else if (x > 0)
        {
            // 右向き
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (y > 0.5 && groundCheck.IsGround())
        {
            Jump();
        } 

        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * this.flap);
    }
}
