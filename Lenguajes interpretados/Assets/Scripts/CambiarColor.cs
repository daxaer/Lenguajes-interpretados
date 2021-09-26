using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    private Camera cam;
    public LayerMask mascara;
    public MeshRenderer[] cubos;
    public MeshRenderer[] esferas;
    public MeshRenderer[] capsulas;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; 
            Ray rayo = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayo, out hit, Mathf.Infinity, mascara))
            {
                Debug.DrawLine(rayo.origin, hit.point, Color.green, 2f);
                if (hit.collider.CompareTag("Cubo")) 
                {
                    for(int i = 0; i < cubos.Length ;i++)
                    {
                        cubos[i].GetComponent<MeshRenderer>().material.color = Random.ColorHSV();//A lo que le di click cambiale el color
                    }
                }
                if (hit.collider.CompareTag("pelota"))
                {
                    for (int i = 0; i < esferas.Length; i++)
                    {
                        esferas[i].GetComponent<MeshRenderer>().material.color = Random.ColorHSV();//A lo que le di click cambiale el color
                    }
                }
                if (hit.collider.CompareTag("Capsula"))
                {
                    for (int i = 0; i < capsulas.Length; i++)
                    {
                        capsulas[i].GetComponent<MeshRenderer>().material.color = Random.ColorHSV();//A lo que le di click cambiale el color
                    }
                }
            }
            else
            {
                Debug.DrawRay(rayo.origin, rayo.direction * 100f, Color.red, 2f);
                //no toco a nada
            }
        }
    }
}
