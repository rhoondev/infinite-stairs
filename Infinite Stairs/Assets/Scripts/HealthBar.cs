using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour

{
    public Slider healthBar;
    public Health playerHealth;
    private void Start()
    {
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
    }
    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
