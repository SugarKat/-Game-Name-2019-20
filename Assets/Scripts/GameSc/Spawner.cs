using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int spID = 0;
    public List<Transform> PlspawnPoints;
    public List<Transform> EnspawnPoints;

    private void Awake()
    {
        if(GameManager.instance == null)
        {
            Debug.LogWarning("GAME NOT STARTED FROM INTENDED PLACE, LAUNCH FROM DIFRENT SCENE");
        }
        GameManager.instance.SetSpawner(this);
    }

    public void InstantiatePlayer(Player _pl)
    {
        _pl.SetControlledCh(Instantiate(_pl.selectedCh.prefab,PlspawnPoints[spID].position,Quaternion.identity));
        SetOtherPoint();
    }
    
    void SetOtherPoint()
    {
        if (spID >= PlspawnPoints.Count)
        {
            spID = 0;
        }
        else
            spID++;
    }
}
