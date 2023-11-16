using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject powerupV;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    public float timer;

    void Start()
    {
       
    }

    
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            float posyY = Random.Range(minY, maxY);
            float posyX = Random.Range(minX, maxX);
            Instantiate(powerupV, new Vector4(transform.position.x, posyY, posyX, 0), Quaternion.identity);
            timer = 1;
        }
    }

}
//untrigger no tinen fisica si se detectan pero se atraviesan unTrigger, un trigger con un collider si funciona, trigger con trigger no funciona
