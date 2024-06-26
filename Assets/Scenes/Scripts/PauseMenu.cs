using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu;
    public bool isPaused;
    public Rigidbody2D rb;
    public GameObject Ball;
    public Animator transition;

    void Start()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToLevelSelect()
    {
        StartCoroutine(WaitThenLoadLevelSelect());
    }

    public void GoToMainMenu()
    {
        StartCoroutine(WaitThenQuitGame());
    }

    public void GoToMainMenuFromLephelThrei()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -2);
    }
    private IEnumerator WaitThenQuitGame()
    {
        Debug.Log("Steven");
        Time.timeScale = 1f;
        transition.SetTrigger("Start");
        Ball.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        Ball.gameObject.GetComponent<LineRenderer>().enabled = false;
        Ball.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("MainMenu");
        
    }

    private IEnumerator WaitThenLoadLevelSelect()
    {
        Debug.Log("Steven");
        Time.timeScale = 1f;
        transition.SetTrigger("Start");
        Ball.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        Ball.gameObject.GetComponent<LineRenderer>().enabled = false;
        Ball.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("LevelSelect");
    }
}