using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public static float timer = 20f;
    public static bool nightTime = false;

    public static bool dawnRise = false;
    public static float timerDawnRise = 0f;

    
    public static float currentTransparency = 0f;
    public static SpriteRenderer spirteBackground;

    //initialize the timer and set background transparency
    void OnEnable(){
        timerDawnRise = 5f;
        spirteBackground = GetComponent<SpriteRenderer>();
        spirteBackground.color = new Color(1f,1f,1f, currentTransparency);
    }

    void FixedUpdate()
    {
        Cycle();
    }

    //if sun is dawn or rising global timer will stop until sun has set/rise
    //else global timer
    void Cycle(){
        if (dawnRise == true){
            timerDawnRise -= Time.deltaTime;
            if (timerDawnRise <= 0){
                timerDawnRise = 5f;
                dawnRise = false;
            }
            else{
                if (nightTime == true){
                    spirteBackground.color = new Color(1f,1f,1f, currentTransparency += 0.1f) * Time.deltaTime;
                }
                else{
                    spirteBackground.color = new Color(1f,1f,1f, currentTransparency -= 0.1f) * Time.deltaTime;
                }
            }
        }
        else{
            timer -= Time.deltaTime;
            if (timer <= 0){
                dawnRise = true;
                if (nightTime == true){
                    nightTime = false;
                    timer = 20f;
                    CharacterController.level += 1;
                }
                else{
                    nightTime = true;
                    timer = 30f;
                }
            }
        }
       
    }

}
