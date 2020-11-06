using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Sprite pausedSprite, unpausedSprite;
    public GameObject sprite;
    bool isPaused = false;
    
    public void pauseGame(){
        if (isPaused){
            Time.timeScale = 1;
            sprite.GetComponent<SpriteRenderer>().sprite = unpausedSprite; 
            isPaused = false;
        }
        else{
            sprite.GetComponent<SpriteRenderer>().sprite = pausedSprite; 
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
