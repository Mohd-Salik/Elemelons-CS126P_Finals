using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Configurations")]
	[Tooltip("How many enemies spawn")]
    public float spawnRate = 10f;
	[Tooltip("How long enemies spawn")]
    public float nextSpawn = 5.0f;

    GameObject enemy;
    float rngRange;
    Vector2 whereToSpawn;

    float ySpawn, xSpawn = 0f;

    void Update(){
        if (Environment.nightTime == true){
            SpawnEnemy();
        }
    }

    void SpawnEnemy(){   
        //randomizes spawn enemy type
        rngRange = Random.Range(0, 4);

        if(Time.time > nextSpawn){
            //add more real-time until next spawn
            nextSpawn = Time.time + spawnRate;

            //spawn air minion in air
            if (Mathf.Abs(rngRange) == 0){
                enemy = GameObject.Find(this.name+"air_minion");
                ySpawn = Random.Range(1f, 2.40f);
            }

            //spawn fire_minion
            else if (Mathf.Abs(rngRange) == 1){
                enemy = GameObject.Find(this.name+"fire_minion");
                ySpawn = -1.49f;
            }

            //spawn water_minion
            else if (Mathf.Abs(rngRange) == 2){
                enemy = GameObject.Find(this.name+"water_minion");
                ySpawn = -1.49f;
            }

            //spawn earth minion
            else{
                enemy = GameObject.Find(this.name+"earth_minion");
                ySpawn = -1.49f;
            }

            //randomizes left and right spawn
            if(Random.value<0.5f){
                xSpawn = -9f;
            }
            else{
                xSpawn = 2f;
            }

            //spawn enemy
            whereToSpawn = new Vector3 (xSpawn, ySpawn, 0f);
            Instantiate (enemy, whereToSpawn, Quaternion.identity);
        }

    }
}
