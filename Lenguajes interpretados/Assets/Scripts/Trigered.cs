using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigered : MonoBehaviour
{
    private Camera cam;
    public LayerMask mascara;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit; //Almacena informacion del rayo
            Ray rayo = cam.ScreenPointToRay(Input.mousePosition);//Crea un rayo en donde se dio click con el mouse desde la pantalla al mundo.
            if (Physics.Raycast(rayo, out hit, Mathf.Infinity, mascara))
            {
                print(hit.collider.gameObject);
                Debug.DrawLine(rayo.origin, hit.point, Color.green, 2f);
                if (hit.collider.CompareTag("Cubo")) // le cambio el color si es una figura
                {
                    hit.collider.GetComponent<MoveAndDie>().BoolMoveAndDie();
                }
            }
            else
            {
                Debug.DrawRay(rayo.origin, rayo.direction * 100f, Color.red, 2f);
            }
        }
    }
    IEnumerator JumpAndDie()
    {
        yield return new WaitForSeconds(1f);
        this.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

    }
}

