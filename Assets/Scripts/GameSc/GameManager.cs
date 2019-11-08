using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public delegate void UIUpdate(int _size);

    public UIUpdate UIupdate;

    [HideInInspector]
    public List<Player> joinedPlayers;

    Spawner spw;

    private void Start()
    {
        if (instance != null)
        {
            Debug.LogError("Only one GameManager can be active at the same time");
            return;
        }
        else
            instance = this;
        DontDestroyOnLoad(this);
        //plM.onPlayerJoined += ctx => OnPlayerJoined();
    }

    public void SetSpawner(Spawner _spw)
    {
        spw = _spw;
        for (int i = 0; i < joinedPlayers.Count; i++)
        {
            spw.InstantiatePlayer(joinedPlayers[i]);
        }
    }

    //public void Set

    public bool OnPlayerJoined(Player _pl)
    {
        joinedPlayers.Add(_pl);
        UIupdate.Invoke(joinedPlayers.Count);
        _pl.name = "Player" + joinedPlayers.Count.ToString();
        if(joinedPlayers.Count >= 3)
            return true;
        return false;
    }
    public void OnPlayerLeft(Player _pl)
    {
        joinedPlayers.Remove(_pl);
        UIupdate.Invoke(joinedPlayers.Count);
        for (int i = 0; i < joinedPlayers.Count; i++) 
        {
            joinedPlayers[i].name = "Player " + 1;
        }
    }
}
