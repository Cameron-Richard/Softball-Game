using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionshover : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverSound;

    public void HoverSound(AudioClip clip)
    {
        mySounds.PlayOneShot(hoverSound);
    }
}