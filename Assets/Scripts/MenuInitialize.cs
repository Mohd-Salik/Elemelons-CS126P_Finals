using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInitialize : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject mainMenu = GameObject.Find(this.name+"/Main Menu");
        mainMenu.SetActive(true);
        
        GameObject storyMenu = GameObject.Find(this.name+"/Story Menu");
        storyMenu.SetActive(false);

        GameObject howMenu = GameObject.Find(this.name+"/How to Play");
        howMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
