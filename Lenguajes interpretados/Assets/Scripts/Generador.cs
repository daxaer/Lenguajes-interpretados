using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject prefab_cubo;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GameObject go = Instantiate(prefab_cubo);
            //Instantiate(prefab_cubo, transform.position, Quaternion.identity);
            go.GetComponent<Rigidbody>().AddForce(Vector3.up * 600f);
        }
    }
}
