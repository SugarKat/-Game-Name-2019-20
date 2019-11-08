using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float move;
    GameObject selectedCharacter;
    ChController controlledCh;

    //[HideInInspector]
    public Character selectedCh;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void SetControlledCh(GameObject _controller)
    {
        controlledCh = _controller.GetComponent<ChController>();
    }

    private void FixedUpdate()
    {
        if (controlledCh == null)
            return;
        controlledCh.Move(move);
    }

    void OnMovement(InputValue value)
    {     
        move = value.Get<Vector2>().x * Time.deltaTime;
    }

    void OnJump(InputValue val)
    {
        if (controlledCh == null)
            return;
        controlledCh.Jump();
    }
    
}
