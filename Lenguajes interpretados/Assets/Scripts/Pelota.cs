using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public MeshRenderer dibujo;
    public Texture textura;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        dibujo.material.SetTexture("_MainTex", textura);
    }
    private void OnTriggerExit(Collider other)
    {
        dibujo.material.SetTexture("_MainTex", null);
    }
}
