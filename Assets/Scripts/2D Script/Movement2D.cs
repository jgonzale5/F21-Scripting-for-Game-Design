using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Rigidbody2D reggiebody;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        //We get the user input in the horizontal axis and store it in x
        float x = Input.GetAxis("Horizontal");

        //An empty vector is created to hold the current change in speed for the player
        Vector2 movement = Vector2.zero;

        //The x axis of movement is set to the user input multiplied by speed, and deltaTime
        movement.x = x * speed * Time.deltaTime;
        movement.y = reggiebody.velocity.y;

        //Movement is the new velocity of the rigidbody
        reggiebody.velocity = movement;

        if (Input.GetButtonDown("Fire1"))
            reggiebody.AddForce(Vector3.up * 1000);
    }
}
