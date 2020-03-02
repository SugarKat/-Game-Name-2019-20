using UnityEngine;
using UnityEngine.UI;

public class BaseInfo : MonoBehaviour
{
    public Slider healthDisplay;
    public BaseHealthBluePrint health;

    private void Start()
    {
        health.health = health.startingHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            if(health.health <= 0)
            {
                health.health = 0;
                //TODO: Padaryti zaidimo pabaigos ekrana kai mirsta ir padaryti kad butu kaskas lyg balsavimas ka daryti toliau
                Debug.Log("Game Over");
                return;
            }
            health.health -= collision.GetComponent<EnemyInfo>().baseDamage;
            Destroy(collision.gameObject,.5f);
            healthDisplay.value = (float)health.health / health.startingHealth;
        }
    }

}
