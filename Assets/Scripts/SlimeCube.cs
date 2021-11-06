using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCube : MonoBehaviour
{
    public GameObject deathParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //I store the POSITION of the TRANSFORM where the OTHER COLLIDER is
            Vector3 otherPosition = other.transform.position;

            //Spawn the DEATHPARTICLES at the OTHERPOSITION with no rotation (Quaternion.identity)
            Instantiate(deathParticles, otherPosition, Quaternion.identity);

            //Destroy() is the function for destroying game objects in your scene
            //Destroy(other.gameObject) will destroy the GAME OBJECT that contains the OTHER COLLIDER
            Destroy(other.gameObject);
        }

    }
}
