using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Espiritu1 : MonoBehaviour
{
    public float speed;
    public Puntaje textObject;
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
            transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balas")
        {
            textObject.puntos = textObject.puntos + 2;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
