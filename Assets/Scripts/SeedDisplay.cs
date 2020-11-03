using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedDisplay : MonoBehaviour
{
    Text number;

    void Start(){
        number = GetComponent<Text>();
    }

    //Display the number of seeds in the GUI
    void Update(){
        if (this.gameObject.name == "Fire Seeds"){
            number.text = CharacterController.fireSeed.ToString();
        }
        else if (this.gameObject.name == "Water Seeds"){
            number.text = CharacterController.waterSeed.ToString();
        }
        else if (this.gameObject.name == "Air Seeds"){
            number.text = CharacterController.airSeed.ToString();
        }
        else if (this.gameObject.name == "Earth Seeds"){
            number.text = CharacterController.earthSeed.ToString();
        }
    }
}
