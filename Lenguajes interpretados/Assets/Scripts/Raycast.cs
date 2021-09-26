using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Raycast : MonoBehaviour
{
    private Camera cam;
    public LayerMask mascara;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();// como el script esta en el objeto de la camara puedo obtener directamente su componente
    }

    // Update is called once per frame
    void Update()
    {
        //Se esta dando un click izquierdo
        if(Input.GetMouseButtonDown(0))// 0 es click izquierdo, 1 es click derecho y 2 es la rueda del raton, 3 y 4 es adelante y atras y 5 si el mouse tiene mas.
        {
            RaycastHit hit; //Almacena informacion del rayo
            Ray rayo = cam.ScreenPointToRay(Input.mousePosition);//Crea un rayo en donde se dio click con el mouse desde la pantalla al mundo.
            if(Physics.Raycast(rayo, out hit, Mathf.Infinity, mascara))// en c# "out" y "ref" significa que es un apuntador. -> en c++ = &hit
            {
                print(hit.collider.gameObject);
                Debug.DrawLine(rayo.origin, hit.point, Color.green, 2f);
                if(hit.collider.CompareTag("figura")) // le cambio el color si es una figura
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();//A lo que le di click cambiale el color
                }
                //hit.pointl;// cordenada en el mundo en donde el rayo pego.
                //print(hit.distance); distancia que viajo el rayo para pegarle al objeto
                //hit.normal; // cual es la direccion de la cara a la que se le pego
                //si entra al if significa que golpeo algo
            }
            else
            {
                Debug.DrawRay(rayo.origin, rayo.direction * 100f, Color.red, 2f);
                //no toco a nada
            }
        }
    }
}
