using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterLibrary",menuName = "Data/Characters Library")]
public class CharackterStash : ScriptableObject
{
    public Character[] stash;
}
