using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Espiritu2 : MonoBehaviour
{
    public float speed;
    public Puntaje textObject;
    public float speedx;
    public float speedy;
    Vector3 direccion = new Vector3(-1, 1, 0);
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0) 
        {
            direccion.y = -1;
        }
        else if (transform.position.y < -3.3)
        {
            direccion.y = 1;
        }
        transform.Translate(new Vector3(direccion.x * speedx, direccion.y * speedy,0)*Time.deltaTime;
    }
   private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "balas")
            {
                textObject.puntos = textObject.puntos + 1;
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
            if (textObject.puntos == 50)
            {
                SceneManager.LoadScene(3);
            }
        }
}
