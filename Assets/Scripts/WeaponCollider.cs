using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollider : MonoBehaviour
{
    Transform playerSwordTransform, playerSwordPosition;
    Rigidbody2D playerRigidBody;
    Vector3 swordDistance;
    public static bool attacking, attackStart, harvestStart;


    void Start(){
        playerSwordTransform = this.transform;
        playerSwordPosition = GameObject.Find("Sword Origin").transform;
    }


    void Update(){
        if (CharacterController.warriorSwap == true){
            if (Input.GetKeyDown("s")){
                attackStart = true;
                Invoke("attack", 0.5f);
		    }
        }
        if (CharacterController.warriorSwap == false){
            if (Input.GetKeyDown("e")){
                harvestStart = true;
                Invoke("attack", 0.5f);
            }
        }
    }

    public void attack(){
		if (!attacking){
			attacking = true;
            swordDistance = new Vector3(0.4f,0,0);
            
            if (CharacterController.warriorFaceRight == true){  
                playerSwordTransform.position += swordDistance;
            }
            else if (CharacterController.warriorFaceRight == false){  
                playerSwordTransform.position -= swordDistance;
            }
			Invoke("attackNow", 0.3f);
        }
	}

	public void attackNow(){
		attacking = false;
        attackStart = false;
        harvestStart = false;
        playerSwordTransform.position = playerSwordPosition.position;
	}

    void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.tag == "Enemy"){
            if (col.gameObject.name == "fire_minion(Clone)"){
                if (CharacterController.selectedType == 0){
                    CharacterController.fireSeed += 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if ((CharacterController.selectedType == 4) && (CharacterController.firePower > 0)){
                    CharacterController.fireSeed += 1;
                    CharacterController.firePower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1; 
                    SoundManagerScript.PlaySound("kill");
                }
                else{
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "water_minion(Clone)"){
                if (CharacterController.selectedType == 0){
                    CharacterController.waterSeed += 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if ((CharacterController.selectedType == 2) && (CharacterController.waterPower > 0)){
                    CharacterController.waterSeed += 1;
                    CharacterController.waterPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else{
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "air_minion(Clone)"){
                if (CharacterController.selectedType == 0){
                    CharacterController.airSeed += 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if ((CharacterController.selectedType == 1) && (CharacterController.airPower > 0)){
                    CharacterController.airSeed += 1;
                    CharacterController.airPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else{
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "earth_minion(Clone)"){
                if (CharacterController.selectedType == 0){
                    CharacterController.earthSeed += 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if ((CharacterController.selectedType == 3) && (CharacterController.earthPower > 0)){
                    CharacterController.earthSeed += 1;
                    CharacterController.earthPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else{
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
           
        }

         if (col.gameObject.tag == "Boss"){
            SoundManagerScript.PlaySound("deathMonster");
            if (col.gameObject.name == "fire_boss(Clone)"){
                if ((CharacterController.selectedType == 4) && (CharacterController.firePower > 0)){
                    CharacterController.fireSeed += 2;
                    CharacterController.firePower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if (CharacterController.selectedType != 4){
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "water_boss(Clone)"){
                if ((CharacterController.selectedType == 2) && (CharacterController.waterPower > 0)){
                    CharacterController.waterSeed += 2;
                    CharacterController.waterPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if (CharacterController.selectedType != 2){
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "air_boss(Clone)"){
                if ((CharacterController.selectedType == 1) && (CharacterController.airPower > 0)){
                    CharacterController.airSeed += 2;
                    CharacterController.airPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if (CharacterController.selectedType != 1){
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else if (col.gameObject.name == "earth_boss(Clone)"){
                if ((CharacterController.selectedType == 3) && (CharacterController.earthPower > 0)){
                    CharacterController.earthSeed += 2;
                    CharacterController.earthPower -= 1;
                    Destroy(col.gameObject);
                    CharacterController.kills += 1;
                    SoundManagerScript.PlaySound("kill");
                }
                else if (CharacterController.selectedType != 3){
                    SoundManagerScript.PlaySound("deathMonster");
                }
            }
            else{
                SoundManagerScript.PlaySound("deathMonster");
            }
           
        }

        else if (col.gameObject.tag == "Plant"){
            SoundManagerScript.PlaySound("harvest");
            if (col.gameObject.name == "plant_air(Clone)"){
                if (CharacterController.airPower < 4){
                    CharacterController.airPower += 1;
                }
            }
            else if (col.gameObject.name == "plant_earth(Clone)"){
                if (CharacterController.earthPower < 4){
                    CharacterController.earthPower += 1;
                }
            }
            else if (col.gameObject.name == "plant_water(Clone)"){
                if (CharacterController.waterPower < 4){
                    CharacterController.waterPower += 1;
                }
            }
            else if (col.gameObject.name == "plant_fire(Clone)"){
                if (CharacterController.firePower < 4){
                    CharacterController.firePower += 1;
                }
            }
            CharacterPlantMechanic.plantLimit = false;
            Destroy(col.gameObject);
            CharacterController.harvests += 1;
        }
    }
}
