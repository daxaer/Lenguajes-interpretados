using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajes : MonoBehaviour
{
    [SerializeField] private GameObject go;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //funciona si conosco el nombre de la clase y la funcion es publica
            go.GetComponent<Receptor>().Hola();
        }
        //cuando no conocemos la clase
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            go.SendMessage("Hola");// como ultimo recurso pero puede llamar funciones privadas y publicas y no importa la clase
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            go.SendMessageUpwards("Hola");// llama la funcion de manera recursiva para arriba
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            go.BroadcastMessage("Hola");// llama la funcion de manera recursiva para abajo
        }
    }
}
