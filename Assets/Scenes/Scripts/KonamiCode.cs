using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KonamiCode : MonoBehaviour
{
    private static readonly KeyCode[] konamiCode =
    {
        KeyCode.UpArrow, KeyCode.UpArrow,
        KeyCode.DownArrow, KeyCode.DownArrow,
        KeyCode.LeftArrow, KeyCode.RightArrow,
        KeyCode.LeftArrow, KeyCode.RightArrow,
        KeyCode.B, KeyCode.A
        
    };

    private int currentIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(konamiCode[currentIndex]))
            {
                currentIndex++;

                if (currentIndex == konamiCode.Length)
                {
                    // Konami Code entered correctly, transition to the desired scene
                    TransitionToSecretScene();
                }
            }
            else
            {
                // Reset if the wrong key is pressed
                currentIndex = 0;
            }
        }
    }

    void TransitionToSecretScene()
    {
        SceneManager.LoadScene("Lephelthrei");
    }
}
