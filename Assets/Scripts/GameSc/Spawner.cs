﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int spID = 0;
    public List<Transform> spawnPoints;

    private void Awake()
    {
        GameManager.instance.SetSpawner(this);
    }

    public void InstantiatePlayer(Player _pl)
    {
        _pl.SetControlledCh(Instantiate(_pl.selectedCh.prefab,spawnPoints[spID].position,Quaternion.identity));
        SetOtherPoint();
    }
    
    void SetOtherPoint()
    {
        if (spID >= spawnPoints.Count)
        {
            spID = 0;
        }
        else
            spID++;
    }
}