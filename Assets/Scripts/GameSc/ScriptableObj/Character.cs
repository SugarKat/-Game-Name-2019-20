using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character",menuName = "Data/Character")]
public class Character : ScriptableObject
{
    public new string name = "Knight";
    public int dif = 0;
    public GameObject prefab;
}
