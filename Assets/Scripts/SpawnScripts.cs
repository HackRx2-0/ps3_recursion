using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScripts : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ballons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);
        Instantiate(ballons[Random.Range(0, ballons.Length)], spawnPoints[Random.Range(0,spawnPoints.Length)].position, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }

}
