using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float spawnInterval = 5;

    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= spawnInterval)
        {
            SpawnBall();
            counter = 0;
        }
    }

    void SpawnBall()
    {
        GameObject.Instantiate(spawnPrefab, this.transform.position, Quaternion.identity);
    }
}
