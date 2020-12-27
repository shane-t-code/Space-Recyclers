using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public string levelName;
    public int maxHealth = 100;
    public HealthBar healthBar;
    public int currentHealth;

    // Start is called before the first frame update
    //void Start()
    //{
    //    currentHealth = maxHealth;
    //    healthBar.SetMaxhealth(maxHealth);
    //    if (currentHealth == 0)
    //    {
    //        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    //    }
    //}
    public static void ShowGameOverScreen(int damage, int currentHealth, HealthBar healthBar)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
        }
    }
    public static void ShowNextLevelScreen(string nextLevelScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelScene);
    }
}