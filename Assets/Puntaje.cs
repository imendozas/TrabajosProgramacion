using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    TMP_Text textComponent;
    public int puntos = 0;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textComponent.text = "PUNTOS: " + puntos;
    }
}
