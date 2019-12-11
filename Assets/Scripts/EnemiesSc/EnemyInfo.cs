using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("EnemyBehavior/EnemyInfo")]
public class EnemyInfo : MonoBehaviour
{
    public int startingHealth = 25;
    public int baseDamage = 5;
    public float combatDamage = 10f;

    int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
    }

}
