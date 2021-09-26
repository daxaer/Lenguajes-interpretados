using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    float contador = 2.0f;
    Coroutine coAvanzar;
    void Start()
    {
        coAvanzar =  StartCoroutine(CAvanzar());
    }
    //invoke no puede recibir parametros, es un poco mas ligero/eficiente
    //corrutina recibe parametros, es un poco mas pesado
    IEnumerator CAvanzar() //Metodo 3
    {
        //Los new wait generan garbage colector
        //si se va a repetir mucho lo mejor seria crear una variable
        WaitForSeconds w2s = new WaitForSeconds(2f);
        while(true)
        {
            yield return w2s;
            transform.Translate(Vector3.forward * 2f);
            //yield return new WaitForEndOfFrame Espera a despues de dibujar
            //yield return new waitForFixedUpdate espera a que terminen las fisicas
            //yield return new WaitUntil Espera otra funcion
        }
    }
    void Avanzar() //Metodo 2
    {
        transform.Translate(Vector3.forward * 2f);
    }
    //Update is called once per frame
    void Update()
    {
        //Metodo 1
        /*
        contador -= Time.deltaTime;// va contando los segundos
        if(contador <= 0)
        {
            //entra cuando pasan 2 segundos
            transform.Translate(Vector3.forward * 2f);
            contador = 2f;
        }
        */
        if(Input.GetKeyDown(KeyCode.S))
        {
            CancelInvoke("Avanzar");
            StopAllCoroutines();
            StopCoroutine("CAvanzar");
            coAvanzar = null;
        }
    }
}
