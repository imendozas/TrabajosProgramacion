using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text textComponent;
    public int puntosVida = 5;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "VIDAS: " + puntosVida;
    }
}
