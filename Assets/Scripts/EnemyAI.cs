using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour
{
    int counter = 500;
    private bool FacingRight = true;
    
    void move(){
        if (counter == 0){
            counter = 500;
            Flip();
        }else{
            counter --;
        }
    }

    void Update(){   
        move();
    }

    //call this function to flip
    private void Flip(){
        // Debug.Log("FLIPPED");
		FacingRight = !FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
