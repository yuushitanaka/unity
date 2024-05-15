using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spornEnemy : MonoBehaviour
{
    [SerializeField] GameObject Enemyprefab;
    [SerializeField] GameObject TargetCube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 0.3f);
    }
    void Spawn()
    {
        Vector3 randomPosition = nextLocation();
        Instantiate(Enemyprefab, randomPosition, Quaternion.identity);

    }
    public Vector3 nextLocation()
    {
        Vector3 cubeCenter = TargetCube.transform.position;
        Vector3 cubeSize = TargetCube.transform.localScale;
        float randomX = Random.Range(cubeCenter.x - cubeSize.x / 2, cubeCenter.x + cubeSize.x / 2);
        float randomY = Random.Range(cubeCenter.y - cubeSize.y / 2, cubeCenter.y + cubeSize.y / 2);
        float randomZ = Random.Range(cubeCenter.z - cubeSize.z / 2, cubeCenter.z + cubeSize.z / 2);
        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
}
