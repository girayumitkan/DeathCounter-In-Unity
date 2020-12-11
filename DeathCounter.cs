using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    public TextMeshProUGUI deathText;
    public static int deathValue;


    void Start()
    {
        deathText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        deathText.text = ":" + deathValue;
    }
}
