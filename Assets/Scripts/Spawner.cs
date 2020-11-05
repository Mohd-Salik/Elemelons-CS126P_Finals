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
    bool rngSatisfied;

    float ySpawn, xSpawn = 0f;

    void Update(){
        if (Environment.nightTime == true){
            SpawnEnemy();
        }
    }

    void SpawnEnemy(){   

        if ((CharacterController.level % 5) == 0){
            while (rngSatisfied == false){
                rngRange = Random.Range(5, 9);
                if ((rngRange == 5) && ((CharacterController.earthPower + CharacterController.earthSeed) > 0)){
                    rngSatisfied = true;
                }
                else if ((rngRange == 6) && ((CharacterController.waterPower + CharacterController.waterSeed) > 0)){
                    rngSatisfied = true;
                }
                else if ((rngRange == 7) && ((CharacterController.airPower + CharacterController.airSeed) > 0)){
                    rngSatisfied = true;
                }
                else if ((rngRange == 8) && ((CharacterController.firePower + CharacterController.fireSeed) > 0)){
                    rngSatisfied = true;
                }
                else{
                    rngRange = Random.Range(1,5);
                    rngSatisfied = true;
                }
            }
            
        }
        else{
            rngRange = Random.Range(1,5);
        }

        if(Time.time > nextSpawn){
            
            //add more real-time until next spawn
            nextSpawn = Time.time + spawnRate;

            //spawn air minion in air
            if (Mathf.Abs(rngRange) == 1){
                enemy = GameObject.Find(this.name+"air_minion");
                ySpawn = Random.Range(1f, 2.40f);
            }

            //spawn water_minion
            else if (Mathf.Abs(rngRange) == 2){
                enemy = GameObject.Find(this.name+"water_minion");
                ySpawn = -1.60f;
            }

            //spawn earth minion
            else if (Mathf.Abs(rngRange) == 3){
                enemy = GameObject.Find(this.name+"earth_minion");
                ySpawn = -1.60f;
            }

            //spawn fire_minion
            else if (Mathf.Abs(rngRange) == 4){
                enemy = GameObject.Find(this.name+"fire_minion");
                ySpawn = -1.60f;
            }

            //spawn earth_boss
            else if (Mathf.Abs(rngRange) == 5){
                enemy = GameObject.Find(this.name+"earth_boss");
                ySpawn = -1.60f;
            }

            else if (Mathf.Abs(rngRange) == 6){
                enemy = GameObject.Find(this.name+"water_boss");
                ySpawn = -1.60f;
            }

            else if (Mathf.Abs(rngRange) == 7){
                enemy = GameObject.Find(this.name+"air_boss");
                ySpawn = -1.60f;
            }

            else if (Mathf.Abs(rngRange) == 8){
                enemy = GameObject.Find(this.name+"fire_boss");
                ySpawn = -1.60f;
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
            rngSatisfied = false;
        }

    }
}
