using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vaatu : MonoBehaviour
{
    public float speedx;
    public float speedy;
    Vector3 direccion = new Vector3 (-1, 1, 0);
    public Puntaje textObject;
    public float timer;
    public GameObject instanceObject;
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(instanceObject, transform.position, Quaternion.identity);
            timer = 1;
        }
        if (transform.position.y > 6)
        {
            direccion.y = -1;
        }
        else if (transform.position.y < -3.3)
        {
            direccion.y = 1;
        }
        transform.Translate(new Vector3(direccion.x * speedx, direccion.y * speedy, 0) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balas")
        {
            textObject.puntos = textObject.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (textObject.puntos == 40)
        {
            SceneManager.LoadScene(3);
        }
    }
}
