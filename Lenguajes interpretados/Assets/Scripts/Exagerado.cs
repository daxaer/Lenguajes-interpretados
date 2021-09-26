using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exagerado : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.right * 500f, ForceMode.Force);
    }
}
