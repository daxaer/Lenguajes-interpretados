using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubo : MonoBehaviour
{
    public GameObject prefab_cubo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab_cubo, prefab_cubo.transform.position = new Vector3(Random.Range(-49.5f,49.5f),5,Random.Range(-49.5f, 49.5f)),Quaternion.identity);
        }
    }
}
