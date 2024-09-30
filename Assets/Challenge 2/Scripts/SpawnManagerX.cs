using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 8;
    private float spawnPosY = 15;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke("SpawnRandomBall", startDelay);
    }


    private void Update() {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval <= 0){
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            int randomBall = Random.Range(0, ballPrefabs.Length);
            Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
            spawnInterval = Random.Range(3, 6);
        }
    }

    // Spawn random ball at random x position at top of play area
    // void SpawnRandomBall ()
    // {
    //     // Generate random ball index and random spawn position
    //     Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    //     int randomBall = Random.Range(0, ballPrefabs.Length);
    //     // instantiate ball at random spawn location
    //     Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    //     spawnInterval = Random.Range(3, 6);
    //     Invoke("SpawnRandomBall", spawnInterval);
    // }

}
