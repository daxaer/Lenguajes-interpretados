using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sndSaltar;
    public AudioClip sndMoneda;
   
    void Update()
    {
        //audioSource.Stop(); 
        //audioSource.clip; // cambia el audio que se va a usar
        //audioSource.Play();
        //audioSource.Pause();
        //audioSource.UnPause();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(sndSaltar);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(sndMoneda);
        }
    }
}
