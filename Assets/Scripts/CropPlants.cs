using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropPlants : MonoBehaviour
{

    Transform plantTransform;

    void Start(){
        plantTransform = this.transform;
    }

    void Update(){
        if ((plantTransform.position.x < -8) | (plantTransform.position.x > 1.5)){
            CharacterPlantMechanic.plantLimit = false;
            Destroy(this.gameObject);
        }
    }
    //if plant collided with player while holding harvest key, then harvest.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy"){ 
            CharacterPlantMechanic.plantLimit = false;
            Destroy(this.gameObject);   
        }
    }
}
