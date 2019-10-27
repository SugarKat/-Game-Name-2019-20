using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerJoining : MonoBehaviour
{
    PlayerInputManager plM;

    void Start()
    {
        plM = GetComponent<PlayerInputManager>();
    }

    public void OnPlayerJoined(PlayerInput _pl)
    {
        if (GameManager.instance.OnPlayerJoined(_pl.GetComponent<Player>()))
            plM.DisableJoining();

    }
    public void OnPlayerLeft(PlayerInput _pl)
    {
        GameManager.instance.OnPlayerLeft(_pl.GetComponent<Player>());
        plM.EnableJoining();
    }
}
