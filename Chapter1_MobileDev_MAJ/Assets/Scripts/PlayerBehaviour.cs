using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// A reference to the Rigidbody component, hi :3
    /// </summary>
    Rigidbody rb;

    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 5f;
    [Tooltip("How fast the ball moves forward automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5f;

    void Start()
    {
                rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }

    /// <summary>
    /// FixedUpdate is a prime place to put physics
    /// calculations happening over a period of time.
    /// </summary>
    void FixedUpdate()
    {
        // Check if we're moving to the side
        var horizontalSpeed = Input.GetAxis("Horizontal") *
        dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}

