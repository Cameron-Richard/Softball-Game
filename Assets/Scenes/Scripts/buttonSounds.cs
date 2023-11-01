using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSounds : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound(AudioClip clip)
    {
        mySounds.PlayOneShot(hoverSound);
    }
    public void ClickSound(AudioClip clip)
    {
        mySounds.PlayOneShot(clickSound);
    }
}
