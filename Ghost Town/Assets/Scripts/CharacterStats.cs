using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
public int maxHealth = 100;
public int currentHealth {get; private set;}
 public Stat damage;
 public Stat armor;
public HealthBar healthBar;
void Awake() {
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.T)){
        TakeDamage(10);
    }
}

public void TakeDamage (int damage)
{
    damage = Mathf.Clamp (damage, 0, int.MaxValue);
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
    Debug.Log (transform.name + "takes"+ damage + "damage");
    if (currentHealth <= 0)
    {
        Die ();
    }
}
    public virtual void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

