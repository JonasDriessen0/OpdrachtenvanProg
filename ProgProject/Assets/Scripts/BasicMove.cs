using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;

    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");

        rb.velocity = rb.transform.forward * move;

        
        float moveSide = Time.deltaTime * speed * Input.GetAxis("Horizontal");

        rb.velocity += rb.transform.right * moveSide;
    }
}

