using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSplash : MonoBehaviour
{
    public GameObject splash;

    private void OnCollisionEnter(Collision collision)
    {
        //The Splash object is spawned at the first contact point of the colision with no rotation
        Instantiate(splash, 
            collision.contacts[0].point, 
            Quaternion.identity);
    }
}
