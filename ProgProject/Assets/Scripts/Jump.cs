using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 20f;

    [HideInInspector]
    public bool onFloor = false;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
            Debug.Log("kut ding werkt");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
            {
            rb.AddForce(Vector3.up * force);
            onFloor = false;
            Debug.Log("spring kut");
        }
    }
}
