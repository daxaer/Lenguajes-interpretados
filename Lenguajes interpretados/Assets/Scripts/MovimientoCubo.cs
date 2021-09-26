using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class MovimientoCubo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private GameObject camara;
    [SerializeField] private bool hijoDeLaCamara;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.forward * -velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, -1f, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 1f, 0f);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(hijoDeLaCamara)
            {
                transform.parent = camara.transform;
                hijoDeLaCamara = false;
            }
            else
            {
                transform.parent = null;
                hijoDeLaCamara = true;
            }
        }
    }
}
