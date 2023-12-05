using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject espiritu1;
    public GameObject espiritu2;
    public GameObject vaatu;

    public float max;
    public float min;
    public float timer;
    public Puntaje textObject;
    //espiritu 1
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    //vatuu
    public float maxX1;
    public float maxY1;
    public float minX1;
    public float minY1;
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textObject.puntos >= 15)
        {
            timer = timer - Time.deltaTime;

            int enemigoElegido = Random.Range(0, 100);

            if (timer <= 0)
            {
                float posY = Random.Range(min, max);
                if (enemigoElegido < 25)
                {
                    timer = timer - Time.deltaTime;
                    if (timer <= 0)
                    {
                        float posyY = Random.Range(minY, maxY);
                        float posyX = Random.Range(minX, maxX);
                        Instantiate(espiritu1, new Vector3(posyX, posyY, 0), Quaternion.identity);
                        timer = 10;
                    }
                }
                else if (enemigoElegido < 50)
                    {
                        Instantiate(espiritu2, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
                    }
                else if (enemigoElegido < 90)
                {
                    float posyY = Random.Range(minY1, maxY1);
                    float posyX = Random.Range(minX1, maxX1);
                    Instantiate(vaatu, new Vector3(posyX, posyY, 0), Quaternion.identity);
                    timer = 10;
                }
                timer = 2;
            }
        }
        }
    }
//else if (enemigoElegido < 90)
//    {
//    float posyY = Random.Range(minY1, maxY1);
//    float posyX = Random.Range(minX1, maxX1);
//    Instantiate(vatuu, new Vector3(posyX, posyY, 0), Quaternion.identity);
//    timer = 10;  
//    }

