using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer dibujo;

    [HideInInspector] public float velocidad;
    [System.NonSerialized] public float velocidad2;

    [SerializeField] private int vidas = 0;

    //void awake()

    // void OnEnable()

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    void Start()
    {
        //////////Rigid Body///

        transform.position = new Vector3(0f, 0f, 0f);//posicion del mundo
        transform.localPosition = new Vector3(0f, 0f, 0f);//posicion del padre
        //Al mover con translate el gameobject no tiene una interaccion con fisicas o no muy importantes
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);

        print(transform.rotation.eulerAngles);
        transform.rotation = Quaternion.Euler(0f, 0f, 45f);

        Quaternion add = Quaternion.Euler(0f, 15f, 0f);
        transform.rotation = transform.rotation * add;

        transform.Rotate(0f, 15f, 0f);

        //Nooooooooooo
        Vector3 rot = transform.rotation.eulerAngles;
        rot.x += 15f;
        transform.rotation = Quaternion.Euler(rot);

        //escalas

        transform.localScale = new Vector3(2f, 2f, 2f);

        dibujo.enabled = true;
        //dibujo.material; 
        dibujo.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        print(dibujo.bounds.size);
        print(dibujo.bounds.min.x);
        print(dibujo.bounds.min.y);
        print(dibujo.bounds.center);

        dibujo.material.color = Color.red;
        //dibujo.material.mainTexture

    }


    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 5f * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnPreRender()

    // void OnPostRender()

    // void On
}
