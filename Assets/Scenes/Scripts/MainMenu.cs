using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        StartCoroutine(waitThenLoad());
    }

    public void PlayTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu()
    {
        StartCoroutine(waitThenLoadBackButton());
    }

    public void PlayLevel1()
    {
        StartCoroutine(waitThenLoadLevel1());
    }

    public void PlayLevel2()
    {
        StartCoroutine(waitThenLoadLevel2());
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    private IEnumerator waitThenLoad()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator waitThenLoadBackButton()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }

    private IEnumerator waitThenLoadLevel1()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene("Level1");
    }

    private IEnumerator waitThenLoadLevel2()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene("Level2");
    }
}
