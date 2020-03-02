using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnController : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rg;
    bool isLanded = true;

    public delegate void AttackAction();
    public AttackAction att;

    public float jumpForce = 10f;
    public float speed = 10f;

    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 dir)
    {
        rg.velocity = new Vector2(dir.x * speed, dir.y * speed/3f);
        if (rg.velocity.x < -0.01f)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        else if (rg.velocity.x > 0.01f)
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
