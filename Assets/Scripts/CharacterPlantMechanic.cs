using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlantMechanic : MonoBehaviour
{   
    //Jump tilling parameters
    public static int jumpCounter = 0, soilCounter = 0;
    float plantLastPosition;
	public Sprite soilImage;

    //debug
    public static bool collidingSoil = false;
    public static string debugCharacterPlantMechanic =  "";

    //spawn of new soil variables
    float xSpawn = 0f;
    Vector2 whereToSpawn;

    //limit planting to one at a time only
    public static bool plantLimit = false;

    //If not warrior, then enable planting mode
    void Update()
    {
        if (CharacterController.warriorSwap == false){
            tryTilling();
            tryPlanting();
        }
    }

    //pressing S key to plant while near the soil
    void tryPlanting(){
        if ((SoilSeparator.playerOnPlant == true) && (CharacterController.selectedType != 0)){
            if (Input.GetKeyDown("s")){
                SoilSeparator.plantingNow = true;
            }
            else{
                SoilSeparator.plantingNow = false;
            }
        }

    }

    //jump in the same location until tilled
    void tryTilling(){
        if ((plantLastPosition != transform.position.x) || (collidingSoil == true)){
            jumpCounter = 0;
        }
        if (jumpCounter == 0){
            plantLastPosition = transform.position.x;
        }
        else if ((jumpCounter == 5) && (plantLimit == false)){
            CharacterPlantMechanic.soilCounter ++;
            jumpCounter = 0;
            Invoke("createSoil", 0.5f);
            plantLimit = true;
        }
    }

    //Create Soil Function, create sprite.
	void createSoil(){

		xSpawn = GameObject.Find(this.name+"/feet").transform.position.x;

        whereToSpawn = new Vector3 (xSpawn, -2f, 0f);
        Instantiate (GameObject.Find("plant_soil"), whereToSpawn, Quaternion.identity);
	}
}
