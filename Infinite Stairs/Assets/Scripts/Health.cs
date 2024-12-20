using UnityEngine;

public class Health : MonoBehaviour
{
   public int currentHealth = 0;
   public int maxHealth = 100;
   public HealthBar healthBar;
   
   void Start()
   {
     currentHealth = maxHealth;
   }

   void Update()
   {
    if(Input.GetKeyDown(KeyCode.Space))
    {
        DamagePlayer(10);
    }
   }
   public void DamagePlayer( int damage)
   {
    currentHealth -= damage;

    healthBar.SetHealth(currentHealth);
   }
}


