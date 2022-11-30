using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{

    private float thrust =100;
    float rotationSpeed = 180;

    Vector3 velocity, acceleration;
    private float drag = 1;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKey(KeyCode.Space))
        {
            acceleration = thrust * transform.forward;
        }
        if (Input.GetKey(KeyCode.A))

        {
            transform.Rotate(new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))

        {
            transform.Rotate(new Vector3(0, 0, 1), -rotationSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Comma))

        {
            transform.Rotate(new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Period))

        {
            transform.Rotate(new Vector3(0, 1, 0), -rotationSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.W))

        {
            transform.Rotate(new Vector3(1, 0, 0), rotationSpeed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.S))

        {
            transform.Rotate(new Vector3(1, 0, 0), -rotationSpeed * Time.deltaTime);

        }



        print(velocity.magnitude);
        if (velocity.magnitude >10) 
            
            acceleration -= drag * velocity;

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        // yaw, pitch, roll
       

    }
}