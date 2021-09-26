using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Busquedas : MonoBehaviour
{
    public Camera cam;
    public GameObject cuboRenderer;
    public GameObject esfera;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam = GetComponentInChildren<Camera>();

        //mas eficiente //cuboRenderer = GameObject.FindGameObjectWithTag("Player");//busca el primer objeto que este etiquetado como player
        //segundo mas eficiente //cuboRenderer = GameObject.Find("Cube");// busca un objeto que se llame cube
        //ultimo //cuboRenderer = GameObject.FindObjectOfType<BoxCollider>().gameObject;//busca un objeto que tenga el componente box collider
        //buscar es pesado no usarlo en update

        esfera = GameObject.Find("Capsule/Sphere");//busca un gameobject llamado capsula con un hijo llamado sphere

        GameObject capsula = GameObject.Find("Capsule");
        esfera = capsula.transform.GetChild(0).gameObject;
        esfera = capsula.transform.Find("sphere").gameObject;

        //todas las busquedas tienen su version s que regresa un arreglo de todos los que encuentre
    }
    
}
