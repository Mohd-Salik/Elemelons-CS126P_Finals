using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    float Spawn = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if(Time.time > nextSpawn)
    {
        
        nextSpawn = Time.time +spawnRate;

        if(Random.value<0.5f)
            Spawn= -8f;
        else
            Spawn= 1.2f;

        // randX = Random.Range (-7.22f, 0.3f);
        whereToSpawn = new Vector2 (Spawn, transform.position.y);
        Instantiate (enemy, whereToSpawn, Quaternion.identity);
    }

    }
}
