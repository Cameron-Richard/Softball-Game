using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public int deathCount;
    public TextMeshProUGUI deathText;
    public TextMeshProUGUI deathTextWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deathText.text = deathCount.ToString();
        deathTextWin.text = deathCount.ToString();
    }
}
