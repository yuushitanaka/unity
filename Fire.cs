using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform Gburrel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot",2f);
    }

    // Update is called once per frame
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, Gburrel.position, Gburrel.rotation);

        Rigidbody rd = bullet.GetComponent<Rigidbody>();

        if (rd)
        {
            rd.AddForce(bullet.transform.up * 40, ForceMode.Impulse);
            rd.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        }
    }
}
