using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject vatuu;
    public GameObject espiritu1;
    public GameObject espiritu2;
    
    public float max;
    public float min;
    public float timer;
    public Puntaje textObject;

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

            int enemigoElegido = Random.Range(0, 100);

            if (timer <= 0)
            {
                float posY = Random.Range(min, max);
                if (enemigoElegido < 25)
                {
                    Instantiate(espiritu1, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
                }
                else if (enemigoElegido < 50)
                {
                    Instantiate(espiritu2, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
                }
                else if (enemigoElegido < 100)
                {
                    Instantiate(vatuu, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
                }

                timer = 1;
            }
        }
    }
}
