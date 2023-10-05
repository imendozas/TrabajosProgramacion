using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    //hacer public el script para unity

    public Vector3 instancePosition = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(instanceObject, instancePosition, Quaternion.identity);
        }
    }
}
