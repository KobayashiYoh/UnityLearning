using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float moveForce = 30.0f;
    private float maxMoveSpeed = 2.0f;

    // Y座標が変更されないよう修正する。
    void adjustPosY()
    {
        if (transform.position.y != -4.0f)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = -4.0f;
            transform.position = newPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int direction = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1;
        }
        float speedx = Mathf.Abs(rb2D.velocity.x);
        if (speedx < maxMoveSpeed)
        {
            rb2D.AddForce(transform.right * direction * moveForce);
        }

        adjustPosY();

    }
}
