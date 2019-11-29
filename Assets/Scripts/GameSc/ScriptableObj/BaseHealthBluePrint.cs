using UnityEngine;

[CreateAssetMenu(fileName = "BaseHealth", menuName = "Data/BaseInfo")]
public class BaseHealthBluePrint : ScriptableObject
{
    public int startingHealth = 50;
    public int health;
}
