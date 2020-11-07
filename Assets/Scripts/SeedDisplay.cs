using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedDisplay : MonoBehaviour
{
    Text number;
    Color newColor;
    
    void Start(){
        newColor = new Color(47/255, 47/255, 46/255, .85f);
        number = GetComponent<Text>();
    }

    //Display the number of seeds in the GUI
    void Update(){
        if (this.gameObject.name == "Fire Seeds"){
            number.text = CharacterController.fireSeed.ToString();
            if(CharacterController.selectedType == 4){
                number.color = Color.red;
            }
            else{
                number.color = newColor;
            }
        }
        else if (this.gameObject.name == "Water Seeds"){
            number.text = CharacterController.waterSeed.ToString();
            if(CharacterController.selectedType == 2){
                number.color = Color.blue;
            }
            else{
                number.color = newColor;
            }
        }
        else if (this.gameObject.name == "Air Seeds"){
            number.text = CharacterController.airSeed.ToString();
            if(CharacterController.selectedType == 1){
                number.color = Color.yellow;
            }
            else{
                number.color = newColor;
            }
        }
        else if (this.gameObject.name == "Earth Seeds"){
            number.text = CharacterController.earthSeed.ToString();
            if(CharacterController.selectedType == 3){
                number.color = Color.green;
            }
            else{
                number.color = newColor;
            }
        }
    }
}
