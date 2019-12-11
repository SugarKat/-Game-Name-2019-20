using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    void Start()
    {
        if (instance == null)
            instance = this;
        else
        {
            Debug.LogError("Something is bad check everything");
            Destroy(this);
        }
    }

    void Update()
    {
        
    }
}
