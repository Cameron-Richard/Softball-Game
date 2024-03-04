using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public Animator transition;

    public void GoToLevelSelect()
    {
        StartCoroutine(WaitThenLoadLevelSelect());
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    private IEnumerator WaitThenLoadLevelSelect()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
