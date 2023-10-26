using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float jumpForce = 680.0f;
    private float walkForce = 30.0f;
    private float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(transform.up * jumpForce);
        }

        // 左右移動
        int direction = 0;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = -1;
        }

        // スピード調整
        float speedx = Mathf.Abs(rb2D.velocity.x);
        if (speedx < maxWalkSpeed)
        {
            rb2D.AddForce(transform.right * direction * walkForce);
        }
    }
}
