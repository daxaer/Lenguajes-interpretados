using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] private GameObject cubo1;
    [SerializeField] private GameObject cubo2;
    [SerializeField] private GameObject capsula1;
    [SerializeField] private GameObject capsula2;
    [SerializeField] private GameObject capsula3;
    [SerializeField] private GameObject cilindro1;
    private bool movimiento = false;
    [SerializeField] private float velocidad;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movimiento = true;
        }
        if(movimiento == true)
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubo") && other.gameObject == cubo1)
        {
            cubo1.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (other.gameObject.CompareTag("Cubo") && other.gameObject == cubo2)
        {
            cubo2.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (other.gameObject.CompareTag("Capsula") && other.gameObject == capsula1)
        {
            capsula1.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (other.gameObject.CompareTag("Capsula") && other.gameObject == capsula2)
        {
            capsula2.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (other.gameObject.CompareTag("Capsula") && other.gameObject == capsula3)
        {
            capsula3.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (other.gameObject.CompareTag("Cilindro") && other.gameObject == cilindro1)
        {
            light.GetComponent<Light>().color = Color.blue;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        cubo1.GetComponent<MeshRenderer>().material.color = Color.white;
        cubo2.GetComponent<MeshRenderer>().material.color = Color.white;

        capsula1.GetComponent<MeshRenderer>().material.color = Color.white;
        capsula2.GetComponent<MeshRenderer>().material.color = Color.white;
        capsula3.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
