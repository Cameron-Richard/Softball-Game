using UnityEngine;

public class FXManager : MonoBehaviour
{
    private static FXManager instance;
    public AudioSource source;
    public AudioClip clickSound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayButtonSound(AudioClip clip)
    {
        source.PlayOneShot(clickSound);
    }
}
