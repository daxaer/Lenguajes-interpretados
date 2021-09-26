using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        //rb.velocity //velocidad del rigid body
        //rb.angularVelocity // velocidad de rotacion
        //al dar un empuje y se va luchando contra la velocidad que ya lleva
        //a-> solo lo empujo y se va a luchar contra la velocidad que ya lleva
        //b-> ignora la velociad y volvemos este empuje su nueva velociad(como resetear y dar empuje)
        //a y b tienen su modo si interactua con su masa o no
        //rb.AddForce(Vector3.up * 500f, ForceMode.Force);
        //rb.AddTorque(Vector3.forward * 200f);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.velocity;
        if (Input.GetKey(KeyCode.W)) 
        {
            vel = Vector3.forward * 5f;
            //rb.velocity = Vector3.forward * 5f;
            //rb.MovePosition(rb.position + Vector3.forward * 5f * Time.deltaTime);//mieve algo brusco pero considera collisio
        }
        vel.y = rb.velocity.y;
        rb.velocity = vel;
    }
}
