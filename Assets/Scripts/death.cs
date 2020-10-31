using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject player;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // public GameObject fire;
    // public GameObject water;
    // public GameObject earth;
    // public GameObject wind;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void OnCollisionEnter2D(Collision2D col) {

        if(!heart3){
                Destroy(player);
            }
        
        if (col.gameObject.name == "fire_minion"){
            Destroy(heart1);
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "fire_minion(Clone)"){
            Destroy(heart1);
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }
             

        if (col.gameObject.name == "water_minion"){
            Destroy(heart1);
            
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "water_minion(Clone)"){
            Destroy(heart1);
            
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "earth_minion"){
            Destroy(heart1);
            
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "earth_minion(Clone)"){
            Destroy(heart1);
            
           if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "air_minion"){
            Destroy(heart1);
            
            if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

        if (col.gameObject.name == "air_minion(Clone)"){
            Destroy(heart1);
            
           if(!heart1){
                Destroy(heart2);
            }
            if(!heart2){
                Destroy(heart3);
            }
        }

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
