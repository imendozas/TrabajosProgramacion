using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerUp : MonoBehaviour
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

    
    void Update()
    {
        if (textObject.puntos >= 8)
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
//untrigger no tinen fisica si se detectan pero se atraviesan unTrigger, un trigger con un collider si funciona, trigger con trigger no funciona
