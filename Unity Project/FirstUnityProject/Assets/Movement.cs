using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
private float Yaw;
{
   float rightrotationspeed = 180;
    float leftrotationspeed = -180;
    Vector3 velocity, acceleration;
   
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            acceleration = transform.forward;
        }
        if (Input.GetKey(KeyCode.A))

        {
            transform.Rotate(new Vector3(0, 0, 1), rightrotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))

        {
            transform.Rotate(new Vector3(0, 0, 1), leftrotationspeed * Time.deltaTime);

        }
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        // yaw, pitch, roll
        Yaw += horizontalInput * Yawamount * Time.deltatime;

    }
}