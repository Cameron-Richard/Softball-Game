using System.Collections;
using UnityEngine;
using TMPro;

public class ButtonTextController : MonoBehaviour
{
    public TMP_Text displayText;
    public float displayDuration = 1f; // Time in seconds to display the text

    private void Start()
    {
        // Hide the text initially
        if (displayText != null)
        {
            displayText.gameObject.SetActive(false);
        }
    }

    public void OnButtonPress()
    {
        // Show the text when the button is pressed
        if (displayText != null)
        {
            displayText.gameObject.SetActive(true);
            displayText.text = "Selected!";
            StartCoroutine(HideTextAfterDelay(displayDuration));
        }
    }

    private IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (displayText != null)
        {
            displayText.gameObject.SetActive(false);
        }
    }
}
