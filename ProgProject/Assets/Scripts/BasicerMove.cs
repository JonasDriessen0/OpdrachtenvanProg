using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicerMove : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;
    [SerializeField]private float rotSpeed = 50f;
    
    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");

        //rb.velocity = rb.transform.forward * move;
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;


        //rb.velocity = rb.transform.forward * move;


        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
    }
}

