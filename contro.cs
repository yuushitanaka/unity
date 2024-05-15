using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("Control",0.1f);
        Control(0.1f);
    }

    public void Control(float p=0.1f) {

        float u = FindAnyObjectByType<GameManager>().uPawer;
        p = u;

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-p, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(p, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.0f, 0.0f, -p);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0.0f, 0.0f, p);
            //transform.Translate(new Vector3(0, 0, p));
        }
        if (Input.GetKey(KeyCode.O))
        {
            transform.Rotate(Vector3.up, 50.0f * Time.deltaTime);
        }
    }
}
