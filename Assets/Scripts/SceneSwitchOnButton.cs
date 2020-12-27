using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchOnButton : MonoBehaviour
{
    public void playGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelOneScene");
    }
    public void playGame2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TutorialScene");
    }
    public void playGame3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }
    public void playGame4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelTwoScene");
    }

}

