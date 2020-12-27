using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollisionScript : MonoBehaviour
{
    public HealthBar healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            TakeDamage(20);

        }

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        SceneManager.ShowGameOverScreen(damage, currentHealth, healthBar);
    }
}
