using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMan : MonoBehaviour
{
    [SerializeField] GameObject Exp;
    [SerializeField] GameObject Exp2;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(Exp, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            FindAnyObjectByType<GameManager>().AddPoint(1);
        }
        else if(collision.gameObject.tag == "Untagged") {
            Instantiate(Exp2, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
