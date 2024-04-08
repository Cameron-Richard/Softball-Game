using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;
    private string skinKey = "SelectedSkin";

    private void Start()
    {
        // Load the selected skin index from PlayerPrefs when the game starts
        if (PlayerPrefs.HasKey(skinKey))
        {
            selectedSkin = PlayerPrefs.GetInt(skinKey);
            sr.sprite = skins[selectedSkin];
        }
    }

    public void NextOption()
    {
        selectedSkin = (selectedSkin + 1) % skins.Count;
        sr.sprite = skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin = (selectedSkin - 1 + skins.Count) % skins.Count;
        sr.sprite = skins[selectedSkin];
    }

    public void SaveSkin()
    {
        // Save the selected skin index to PlayerPrefs
        PlayerPrefs.SetInt(skinKey, selectedSkin);
        PlayerPrefs.Save();
    }
}

