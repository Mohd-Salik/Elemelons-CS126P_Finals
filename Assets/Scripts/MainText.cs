using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour
{
    // public static bool win = false;
    // public static bool onstart_point = false;
    // public static bool count_down = true;
    // public static float timer = 5000f;
    Text mainText;

    void Start(){
        mainText = GetComponent<Text>();
    }

    void updateTextUI(){

        if (CharacterController.warriorSwap == true)
        {
            mainText.text = "WARRIOR MODE";
        }
        else if (CharacterController.warriorSwap == false)
        {
            mainText.text = "FARMING MODE";
        }
    }

    void Update(){
        updateTextUI();
    }
}
