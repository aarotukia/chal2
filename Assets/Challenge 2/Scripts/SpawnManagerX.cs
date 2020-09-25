using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 22;
    private bool isSpawning;
    //  private float startDelay = 1.0f;
    // private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        isSpawning = false;
      
    }

   void Update()
    {
     //spawns balls at random intervals between 3 and 5 seconds                      (BONUS 1)
        if (!isSpawning)
        {
            float timer = Random.Range(3, 5);
            Invoke("SpawnRandomBall", timer);
            isSpawning = true;
        }

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        isSpawning = false;
    }

}
