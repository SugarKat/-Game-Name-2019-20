using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChController : MonoBehaviour
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
    public void Attack()
    {
        //TODO:
        //Start attack animation and action
        Debug.Log("attack not animating if this here");
        att.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isLanded = true;
    }
}
