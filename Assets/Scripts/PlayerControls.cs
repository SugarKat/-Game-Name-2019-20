using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PlayerNum
{
    Player1,
    Player2,
    Player3,
    Player4
}

public class PlayerControls : MonoBehaviour
{
    Rigidbody2D rg;
    float move;
    bool isLanded = true;

    public PlayerNum Num = PlayerNum.Player1;
    public float jumpForce = 10f;
    public float speed = 10f;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        GameManager.instance.SetPL(GetComponent<PlayerInput>());
    }

    private void Update()
    {
        //Vector2 m = new Vector2(move, 0) * Time.deltaTime * speed;

        rg.velocity = new Vector2(move,rg.velocity.y);
    }

    void OnMovement(InputValue value)
    {     
        move = value.Get<Vector2>().x * Time.deltaTime * speed;
    }

    void OnJump()
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
