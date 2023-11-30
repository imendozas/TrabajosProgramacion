using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoExistir : MonoBehaviour
{
    public GameObject enemy;
    public float min;
    public float max;
    public Puntaje textObject;

    public float timer;
    
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }

    
    void Update()
    {
        if (textObject.puntos <= 8)
        {
            timer = timer - Time.deltaTime;
            if (timer <= 0)
            {
                float posy = Random.Range(min, max);
                Instantiate(enemy, new Vector3(transform.position.x, posy, 0), Quaternion.identity);
                timer = 1;
            }
        }
    }

}
