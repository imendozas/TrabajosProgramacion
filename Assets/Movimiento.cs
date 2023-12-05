using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    public GameObject balaPos;
    public float speed;
    public Vidas textObject;
    public SpriteRenderer spriteRenderer;
    public Sprite imgArriba;
    public Sprite imgAbajo;
    public Sprite imgBala;
    public Sprite imgLado;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        textObject = FindAnyObjectByType<Vidas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.sprite = imgBala;
            Instantiate(instanceObject, new Vector3(balaPos.transform.position.x, balaPos.transform.position.y, 0), Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = imgArriba;
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.sprite = imgAbajo;
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.sprite = imgLado;
            transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.sprite = imgLado;
            transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            textObject.puntosVida = textObject.puntosVida - 1;
            Destroy(collision.gameObject);
            if (textObject.puntosVida < 1)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }

        if (collision.gameObject.tag == "powerupV")
        {
            textObject.puntosVida = textObject.puntosVida + 2;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "powerupB")
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                spriteRenderer.sprite = imgBala;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Instantiate(instanceObject, new Vector3(balaPos.transform.position.x, balaPos.transform.position.y + 1, 0), Quaternion.identity);
                    Instantiate(instanceObject, new Vector3(balaPos.transform.position.x, balaPos.transform.position.y - 1, 0), Quaternion.identity);
                }
                Destroy(collision.gameObject);
            }

        }
    }
}

