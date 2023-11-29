using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public Animator transition;

    public void NextLevel()
    {
        StartCoroutine(waitThenLoad());
    }

    public void LevelSelect()
    {
        StartCoroutine(waitThenLoadLevelSelectWinScreen());
    }
    public void MainMenu()
    {
        StartCoroutine(waitThenLoadMainMenuWinScreen());
    }

    private IEnumerator waitThenLoad()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator waitThenLoadMainMenuWinScreen()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("MainMenu");
    }

    private IEnumerator waitThenLoadLevelSelectWinScreen()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("LevelSelect");
    }
}
