using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TillingCounter : MonoBehaviour
{
    Text screenText;

    // Start is called before the first frame update
    void Start()
    {
        screenText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        screenText.text = "TILL COUNTER: " + CharacterPlantMechanic.jumpCounter;
    }
}
