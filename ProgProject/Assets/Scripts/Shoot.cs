using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            Destroy(bullet, 3f);
        }
    }
}