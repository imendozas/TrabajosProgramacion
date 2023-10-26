using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    public float speed;
    public Vidas textObject;


    void Start()
    {
        textObject = FindAnyObjectByType<Vidas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(instanceObject, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemigo")
        {
            textObject.puntosVida = textObject.puntosVida - 1;
            Destroy(collision.gameObject);
            if(textObject.puntosVida <1)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
