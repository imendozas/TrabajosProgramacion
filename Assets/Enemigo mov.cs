using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigos : MonoBehaviour
{
    public float speed;
    public Puntaje textObject;
    
    
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balas")
        {
            textObject.puntos = textObject.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (textObject.puntos == 50) 
        {
            SceneManager.LoadScene(3);
        }
    }
}



