using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    public float speed;
    //hacer public el script para unity

    
    void Start()
    {
        
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
}
