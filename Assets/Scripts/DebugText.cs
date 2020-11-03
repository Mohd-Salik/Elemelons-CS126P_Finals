using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : MonoBehaviour
{
    Text debugText;

    // Start is called before the first frame update
    void Start()
    {

        debugText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // debugText.text = "DawnRise: " + Environment.dawnRise.ToString() + "\nTimerDAWN:" + Environment.timerDawnRise.ToString("0") + "\nNightTime: " + Environment.nightTime.ToString() + "\nTIMER: " + Environment.timer.ToString("0");
        debugText.text = CharacterPlantMechanic.debugCharacterPlantMechanic;
    }
}
