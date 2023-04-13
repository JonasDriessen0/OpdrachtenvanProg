using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed = 500f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = -rb.transform.forward * speed * Time.fixedDeltaTime;
    }
}