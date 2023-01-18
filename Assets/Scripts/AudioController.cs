using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
     void Start ()   
     {
         GetComponent<AudioSource>().playOnAwake = false;
     }        
 
     void OnCollisionEnter (Collision collision)  //Plays Sound Whenever collision detected
     {
        if (collision.relativeVelocity.magnitude > 5)
            GetComponent<AudioSource>().Play();
     }
}
