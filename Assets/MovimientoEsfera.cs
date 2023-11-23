using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{
    public float speed;
    

    void Update()
    {
       transform.Translate(Vector3.right * speed  * Time.deltaTime);
       
    }
    

}
