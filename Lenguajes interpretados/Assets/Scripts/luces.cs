using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luces : MonoBehaviour
{
    public Light luz;
    float rango;
    public float velocidad;
    public float rangoMin;
    public float rangoMax;
    // Start is called before the first frame update
    void Start()
    {
        luz.color = Color.red;
        luz.range = 10.3f;
        luz.enabled = true;
        rango = luz.range;
    }

    // Update is called once per frame
    void Update()
    {
        rango += velocidad * Time.deltaTime;
        luz.range = rango;
        if(rango < 0f)
        {
            if(rango <= rangoMin)
            {
                velocidad *= -1f;
            }
        }
        else if (velocidad < 0f)
        {
            if (rango <= rangoMax)
            {
                velocidad *= -1f;
            }
        }
    }
}
