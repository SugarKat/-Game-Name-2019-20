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
    Player1Controls controller;
    Rigidbody2D rg;
    float move;
    bool isLanded = true;

    public PlayerNum Num = PlayerNum.Player1;
    public float jumpForce = 10f;
    public float speed = 10f;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        controller = new Player1Controls();
        switch(Num)
        {
            case PlayerNum.Player1:

                controller.Movement1.Movement.performed += ctx => move = ctx.ReadValue<Vector2>().x;
                controller.Movement1.Movement.canceled += ctx => move = 0;
        
                controller.Movement1.Jump.performed += ctx => Jump();
                break;
            case PlayerNum.Player2:
                controller.Movement2.Movement.performed += ctx => move = ctx.ReadValue<Vector2>().x;
                controller.Movement2.Movement.canceled += ctx => move = 0;
        
                controller.Movement2.Jump.performed += ctx => Jump();
                break;
            case PlayerNum.Player3:
                controller.Movement3.Movement.performed += ctx => move = ctx.ReadValue<Vector2>().x;
                controller.Movement3.Movement.canceled += ctx => move = 0;
        
                controller.Movement3.Jump.performed += ctx => Jump();
                break;
            case PlayerNum.Player4:
                controller.Movement4.Movement.performed += ctx => move = ctx.ReadValue<Vector2>().x;
                controller.Movement4.Movement.canceled += ctx => move = 0;
        
                controller.Movement4.Jump.performed += ctx => Jump();
                break;

        }
    }

    private void Update()
    {
        Vector2 m = new Vector2(move, 0) * Time.deltaTime * speed;

        rg.velocity = new Vector2(m.x,rg.velocity.y);
    }

    void Jump()
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
    private void OnEnable()
    {
        controller.Movement1.Enable();
        controller.Movement2.Enable();
        controller.Movement3.Enable();
        controller.Movement4.Enable();
    }
    private void OnDisable()
    {
        controller.Movement1.Disable();
        controller.Movement2.Disable();
        controller.Movement3.Disable();
        controller.Movement4.Disable();
    }
}
