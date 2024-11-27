using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class liftScript : MonoBehaviour
{
    public Rigidbody rb;
    public float liftCoefficent;
    public float handling;
    public float attackIsZero;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        // Calculates and applies lift
        float attackAngle = Vector3.Angle(transform.forward, rb.velocity);
        float attackCoefficent = ((float)Math.Tanh(-attackAngle * (attackAngle - attackIsZero) / 5) + 1f) / 2;
        rb.velocity += attackCoefficent * Mathf.Pow(rb.velocity.magnitude, 2) * (liftCoefficent / rb.mass) * transform.up * Time.deltaTime;

        // Shifts velocity towards heading
        rb.velocity += (transform.forward.normalized * rb.velocity.magnitude - rb.velocity) * handling * Time.deltaTime;





    }
}
