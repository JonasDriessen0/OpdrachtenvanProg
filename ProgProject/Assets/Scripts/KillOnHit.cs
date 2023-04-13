using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Explode(coll.gameObject);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Explode(coll.gameObject);
        }
    }

    void Explode(GameObject obj)
    {
        GameObject expl = Instantiate(effect, obj.transform.position, Quaternion.identity);
        Destroy(expl, 2f);
        Destroy(obj, 0.1f);
        audioSource.Play();
    }
}