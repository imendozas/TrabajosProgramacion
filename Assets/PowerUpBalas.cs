using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBalas : MonoBehaviour
{
    public GameObject powerupV;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public Puntaje textObject;
    public float timer;
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textObject.puntos >= 20)
        {
            timer = timer - Time.deltaTime;
            if (timer <= 0)
            {
                float posyY = Random.Range(minY, maxY);
                float posyX = Random.Range(minX, maxX);
                Instantiate(powerupV, new Vector3(posyX, posyY, 0), Quaternion.identity);
                timer = 10;
            }

        }
    }
}
