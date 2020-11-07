using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public Sprite pausedSprite, unpausedSprite;
    public GameObject sprite, menu, how2play, quit;
    bool isPaused = false;
    
    void Awake(){
        menu.SetActive(false);
        how2play.SetActive(false);
        quit.SetActive(false);
    }

    public void pauseGame(){
        if (isPaused){
            menu.SetActive(false);
            how2play.SetActive(false);
            quit.SetActive(false);
            Time.timeScale = 1;
            sprite.GetComponent<SpriteRenderer>().sprite = unpausedSprite; 
            isPaused = false;
        }
        else{
            menu.SetActive(true);
            sprite.GetComponent<SpriteRenderer>().sprite = pausedSprite; 
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
