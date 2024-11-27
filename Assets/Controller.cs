using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Rigidbody rb;
    public float boostForce;
    public float angularAcceleration;
    public float maxAngularVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        // Gets mouse position on screen
        Vector3 mouseScreenPosition = Input.mousePosition;

        Debug.DrawLine(transform.position, transform.position + transform.forward * 12, Color.red);
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += boostForce / rb.mass * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.angularVelocity += -angularAcceleration * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.angularVelocity += angularAcceleration * Time.deltaTime * transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.angularVelocity += -angularAcceleration * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.angularVelocity += angularAcceleration * 2 * Time.deltaTime * transform.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.angularVelocity += angularAcceleration * 2 * Time.deltaTime * transform.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.angularVelocity -= angularAcceleration * 2 * Time.deltaTime * transform.up;
        }

    }
}
