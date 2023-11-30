using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Espiritu1 : MonoBehaviour
{
    public float speed;
    public Puntaje textObject;
    
    public float timer;
    void Start()
    {
        textObject = FindAnyObjectByType<Puntaje>();
    }


    void Update()
    {
            transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
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
