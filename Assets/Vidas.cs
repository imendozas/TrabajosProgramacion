using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    TMP_Text textComponent;
    public int vidas = 5;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Vidas: " + vidas;
    }
}
