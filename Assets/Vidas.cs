using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Vidas : MonoBehaviour
{
    public Puntaje textObject;
    TMP_Text textComponent;
    public int puntosVida = 5;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
        textObject = FindAnyObjectByType<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textObject.puntos <= 20)
        {
            textComponent.text = "VIDAS: " + puntosVida;
        }
    }
}
