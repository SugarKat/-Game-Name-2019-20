using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSetter : MonoBehaviour
{
    public Transform target;
    EnemyAI_Movement root;

    private void Awake()
    {
        root = GetComponent<EnemyAI_Movement>();
        root.SetTarget(target);
    }
}
