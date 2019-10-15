using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public PlayerInput pl;

    private void Start()
    {
        if (instance != null)
        {
            Debug.LogError("Only one GameManager can be active at the same time");
            return;
        }
        else
            instance = this;
    }

    public void SetPL(PlayerInput _pl)
    {
        pl = _pl;
    }

    void Update()
    {
        if (pl == null)
            return;
        InputDevice[] inD = pl.user.pairedDevices.ToArray();
        Debug.Log(inD[0].id);

    }
}
