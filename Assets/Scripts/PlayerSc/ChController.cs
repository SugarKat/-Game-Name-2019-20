using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChController : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rg;
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
        if (rg.velocity.x < -0.01f)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        else if (rg.velocity.x > 0.01f)
            transform.localScale = new Vector3(1f, 1f, 1f);
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
