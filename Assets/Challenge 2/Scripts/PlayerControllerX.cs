using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    bool canSpawnDog = true;

    [SerializeField] float spawnInterval;

    float currentSpawnInterval = 0;
    private void Start() {
        bool canSpawnDog = true;
    }
    // Update is called once per frame
    void Update()
    {   
        currentSpawnInterval -= Time.deltaTime;
        if(currentSpawnInterval <= 0){
            canSpawnDog = true;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog) {
            canSpawnDog = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            currentSpawnInterval = spawnInterval;  
        }
    }
}
