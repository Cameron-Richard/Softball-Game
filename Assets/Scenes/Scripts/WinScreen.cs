using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
