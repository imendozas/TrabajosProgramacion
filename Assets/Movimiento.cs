using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    public float speed;
    public Vidas textObject;
    public SpriteRenderer spriteRenderer;
    public Sprite imgArriba;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            spriteRenderer.sprite = imgArriba;
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
                SceneManager.LoadScene(2);
            }
        }

    }
}

