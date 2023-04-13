using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer r;
    private KeepScore scoreScript;
    private AudioSource source;
    private ParticleSystem ps;

    private void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();

        scoreScript = FindObjectOfType<KeepScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            source.Play();
            ps.Play();
            Destroy(gameObject, 0.5f);
            scoreScript.AddScore(1);
        }
    }
}