using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CombatInfo", menuName = "Data/CombatInfo")]
public class CombatInfo : ScriptableObject
{
    public enum CombatType
    {
        Melee,
        Ranged,
        Mage
    }

    public CombatType type;
    public int damage = 10;
    public float attackSpeed = .5f;
    public float knockBackStrength = 20f;
    [Tooltip("Only applies for melee")]
    public float weaponReach = .5f;

}
