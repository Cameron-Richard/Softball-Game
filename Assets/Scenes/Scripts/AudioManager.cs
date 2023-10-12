using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip bgmScene1;
    public AudioClip bgmScene2;
    public AudioClip bgmScene3;
    public AudioClip bgmScene4;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            // Subscribe to the scene loaded event
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Start playing the initial background music
        PlayBackgroundMusic(bgmScene1);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Handle background music for different scenes
        if (scene.name == "MainMenu")
        {
            PlayBackgroundMusic(bgmScene1);
        }
        else if (scene.name == "LevelSelect")
        {
            PlayBackgroundMusic(bgmScene2);
        }
        else if (scene.name == "Tutorial")
        {
            PlayBackgroundMusic(bgmScene3);
        }
        else if (scene.name == "Lephelthrei")
        {
            PlayBackgroundMusic(bgmScene4);
        }
    }

    // Play background music and handle overlapping
    void PlayBackgroundMusic(AudioClip clip)
    {
        if (musicSource.clip != clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Handle other audio-related updates if needed
    }
}