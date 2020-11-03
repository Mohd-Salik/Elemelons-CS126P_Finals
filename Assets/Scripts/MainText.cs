using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour
{

    Text mainText;

    void Start(){
        mainText = GetComponent<Text>();
    }

    //Sample Text UI for debbuging purposes
    void updateTextUI(){

        if (CharacterController.warriorSwap == true){
            mainText.text = "WARRIOR MODE";
        }
        else if (CharacterController.warriorSwap == false){
            mainText.text = "FARMING MODE";
        }
    }

    void Update(){
        updateTextUI();
    }
}
