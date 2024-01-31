using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    
    public void PlayGame()
    {
        StartCoroutine(waitThenLoad());
    }

    public void PlayTutorial()
    {
        StartCoroutine(waitThenLoadLevelSelect());
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

    public void PlayLevel3()
    {
        StartCoroutine(waitThenLoadLevel3());
    }

    public void LoadShop()
    {
        StartCoroutine(waitThenLoadShopMenu());
    }

    public void LoadMainMenu()
    {
        StartCoroutine(waitThenLoadMainMenu());
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    private IEnumerator waitThenLoad()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator waitThenLoadLevelSelect()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator waitThenLoadBackButton()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }

    private IEnumerator waitThenLoadLevel1()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("Level1");
    }

    private IEnumerator waitThenLoadLevel2()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("Level2");
    }

    private IEnumerator waitThenLoadLevel3()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("Level3");
    }

    private IEnumerator waitThenLoadShopMenu()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("ShopMenu");
    }

    private IEnumerator waitThenLoadMainMenu()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("MainMenu");
    }
}
