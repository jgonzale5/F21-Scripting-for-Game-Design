using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsInput : MonoBehaviour
{
    public float jumpForce = 1;
    public float maxForce = 10;
    public Rigidbody reggiebody;

    private float accumulatedForce = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            accumulatedForce = 0;

            //This will add jumpForce when you tap the key.
            //reggiebody.AddForce(Vector3.down * jumpForce);

            //Debug.Log("Jump down");
        }
        else if (Input.GetButton("Jump"))
        {
            accumulatedForce += jumpForce * Time.deltaTime;

            if (accumulatedForce > maxForce)
            {
                accumulatedForce = maxForce;
            }

            //This will add the jumpForce every frame we're holding the key. 
            //By adding Time.delta we distribute that force accross every second we're holding the key.
            //reggiebody.AddForce(Vector3.up * jumpForce * Time.deltaTime);

            //Debug.Log("Jump hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            reggiebody.AddForce(Vector3.up * accumulatedForce);

            //This will add jumpForce when you release the key.
            //reggiebody.AddForce(Vector3.up * jumpForce);

            //Debug.Log("Jump up");
        }
    }
}
