using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilate : MonoBehaviour
{
    [SerializeField] Material[] Mycolors;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = Mycolors[Random.Range(0, 3)];
        Invoke("Kill", 10f);
        Invoke("Move",2f);
    }
    Vector3 LastPosition, NextPosition;

    // Update is called once per frame
    void Kill()
    {
        Destroy(gameObject);
    }
    void Move()
    {
        spornEnemy spon=FindAnyObjectByType<spornEnemy>();
        if (spon)
        {
            NextPosition = spon.nextLocation();
            LastPosition = transform.position;
            /*transform.position = nextMovePoint;
            Invoke("Move", Random.Range(1, 5));*/
            Hashtable hash = new Hashtable()
            {
                {"from",0 },
                {"to",1f },
                {"time",2f },
                {"easeType",iTween.EaseType.easeInOutBounce},
                {"onupdate","OnMoving" },
                {"oncomplete","Done" },
            };
            iTween.ValueTo(gameObject, hash);
        }
    }
    void OnMoving(float fValue)
    {
        transform.position = Vector3.Lerp(LastPosition, NextPosition, fValue);
    }
}
