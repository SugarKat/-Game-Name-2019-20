using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChController : MonoBehaviour
{
    Rigidbody2D rg;
    bool isLanded = true;

    public float jumpForce = 10f;
    public float speed = 10f;

    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();

    }

    public void Move(float _move)
    {
        rg.velocity = new Vector2(_move*speed, rg.velocity.y);
    }
    public void Jump()
    {
        if (!isLanded)
            return;
        rg.velocity = Vector2.up * jumpForce;
        isLanded = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isLanded = true;
    }
}
