using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sakujo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Killme", GetComponent<ParticleSystem>().duration + 0.1f);
    }

    // Update is called once per frame
    void Killme()
    {
        Destroy(gameObject);
    }
}
