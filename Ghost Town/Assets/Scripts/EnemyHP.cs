using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame

   public void DoDamage(int damage){
        currentHealth-=damage;

        healthBar.SetHealth(currentHealth);

        
    }
       public void TakeDamage(int damage){
        currentHealth-=damage;

        healthBar.SetHealth(currentHealth);
       }

           void Update()
    {
    if (currentHealth <= 0){
        Destroy(gameObject);
    }
    }
}
