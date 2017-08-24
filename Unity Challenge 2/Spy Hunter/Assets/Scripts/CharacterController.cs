﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {


    [System.Serializable]
    public class Boundary
    {
        public float xMin, xMax, zMin, zMax;
    }


    Rigidbody rBody;

	void Start ()
    {
       if (GetComponent<Rigidbody>())
            rBody = GetComponent<Rigidbody>();
    }

    

    public float speed;
    public float tilt;
    public Boundary boundary;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rBody.velocity = movement * speed;

        rBody.position = new Vector3
        (
            Mathf.Clamp(rBody.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rBody.position.z, boundary.zMin, boundary.zMax)
        );

        rBody.rotation = Quaternion.Euler(0.0f, 0.0f, rBody.velocity.x * tilt);
    }



}


