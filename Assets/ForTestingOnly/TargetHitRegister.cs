using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInfo))]
public class TargetHitRegister : MonoBehaviour
{
    EnemyInfo currentInfo;

    private void Start()
    {
        currentInfo = GetComponent<EnemyInfo>();
    }

    public void ReceiveOof(int dmg, float knockBack)
    {
        Debug.Log("oof, just took damage");
        currentInfo.TakeDamage(dmg);
        //TODO: apply knockback effect
    }
}
