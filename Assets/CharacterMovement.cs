using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float multiple = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical") * 10 * multiple;
        float horizontal = Input.GetAxis("Horizontal") * 10 * multiple;
        Vector3 translate = new Vector3(horizontal, rb.velocity.y, vertical);
        transform.LookAt(transform.position + new Vector3(horizontal, 0, vertical));
        rb.velocity = translate;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Fast")
            multiple = 2;
        if (collision.gameObject.tag == "Normal")
            multiple = 1;
        if (collision.gameObject.tag == "Slow")
            multiple = 0.5f;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Fast")
    //        multiple = 2;
    //    if (collision.gameObject.tag == "Normal")
    //        multiple = 1;
    //    if (collision.gameObject.tag == "Slow")
    //        multiple = 0.5f;
    //}

}