using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilSeparator : MonoBehaviour
{   
    //parameters
    public static bool plantingNow = false;
    public static bool playerOnPlant = false;

    //where to spawn the fruit game object
    string type = "";
    float xSpawn = 0f;
    Vector2 whereToSpawn;
    public static string debugSoilSeparator = "";

    void Update(){
        if (plantingNow == true){
            CharacterPlant();
            plantingNow = false;
            type = "";
        }
    }

    //instantiate the new fruit game object
    void CharacterPlant(){
        xSpawn = GameObject.Find(this.name).transform.position.x;
        whereToSpawn = new Vector3 (xSpawn, -3f, 0f);

        if (CharacterController.selectedType == 0){
            Debug.Log("No Element Selected");
        }

        if ((CharacterController.selectedType == 1) && (CharacterController.airSeed > 0)){
            type = "plant_air";
            CharacterController.airSeed -= 1;
        }
        else if ((CharacterController.selectedType == 2) && (CharacterController.waterSeed > 0)){
            type = "plant_water";
             CharacterController.waterSeed -= 1;
        }
        else if ((CharacterController.selectedType == 3) && (CharacterController.earthSeed > 0)){
            type = "plant_earth";  
            CharacterController.earthSeed -= 1;
        }
        else if ((CharacterController.selectedType == 4) && (CharacterController.fireSeed > 0)){
            type = "plant_fire";
            CharacterController.fireSeed -= 1;     
        }
        
        if (type != ""){
            Instantiate (GameObject.Find(type), whereToSpawn, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else{
            Debug.Log("Insufficient Seeds");
        }
    }

    //player can only plant when near the soil
    void OnTriggerStay2D(Collider2D col){
        if (col.gameObject.tag == "Enemy"){
            CharacterPlantMechanic.plantLimit = false;
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Player Group"){
            CharacterPlantMechanic.collidingSoil = true;
            if (playerOnPlant == false){
                playerOnPlant = true;
            }
        }
    }

    //player cannot plant when away from soil
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player Group"){
            CharacterPlantMechanic.collidingSoil = false;
            playerOnPlant = false;
        }
    }
}
