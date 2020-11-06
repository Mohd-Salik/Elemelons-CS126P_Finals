using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButton : MonoBehaviour
{   
    public Sprite pSprite, fSprite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterController.warriorSwap == false){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = pSprite; 
            this.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else{
            this.gameObject.GetComponent<SpriteRenderer>().sprite = fSprite; 
            this.transform.localScale = new Vector3(3f, 3f, 1f);
        }
       
    }
}
