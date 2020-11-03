using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropPlants : MonoBehaviour
{

    //if plant collided with player while holding harvest key, then harvest.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (Input.GetKey("s")){
            //harvesting
            if (col.gameObject.tag == "Player"){  
                HarvestFruit();
            }
        }
    }

    //Increment power depending on the harvested fruit, then destroy.
    void HarvestFruit(){
        if (this.gameObject.name == "plant_air(Clone)"){
            if (CharacterController.airPower < 5){
                CharacterController.airPower += 1;
            }
        }
        else if (this.gameObject.name == "plant_earth(Clone)"){
            if (CharacterController.earthPower < 5){
                CharacterController.earthPower += 1;
            }
        }
        else if (this.gameObject.name == "plant_water(Clone)"){
            if (CharacterController.earthPower < 5){
                CharacterController.earthPower += 1;
            }
        }
        else if (this.gameObject.name == "plant_fire(Clone)"){
            if (CharacterController.airPower < 5){
                CharacterController.airPower += 1;
            }
        }
        CharacterPlantMechanic.plantLimit = false;
        Destroy(this.gameObject);
    }
}
