using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public static int hearts = 3;
    SpriteRenderer spriteHeart1, spriteHeart2, spriteHeart3;
    public static bool respawn = false;

    void Start(){
        spriteHeart1 = heart1.GetComponent<SpriteRenderer>();
        spriteHeart2 = heart2.GetComponent<SpriteRenderer>();
        spriteHeart3 = heart3.GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col) {
        
        if (WeaponCollider.attacking == false){
            if ((col.gameObject.tag == "Enemy") | (col.gameObject.tag == "Boss")){
                if (hearts == 3){
                    spriteHeart1.color = new Color(1f,1f,1f, .3f);
                    hearts -= 1;
                }
                else if (hearts == 2){
                    spriteHeart2.color = new Color(1f,1f,1f, .3f);
                    hearts -= 1;
                }
                else if (hearts == 1){
                    spriteHeart3.color = new Color(1f,1f,1f, .3f);
                    respawn = true;
                    Invoke("RespawnHearts", 5f);
                }
              
            }
        }
    }

    void RespawnHearts(){
        hearts = 3;
        spriteHeart1.color = new Color(1f,1f,1f, 1f);
        spriteHeart2.color = new Color(1f,1f,1f, 1f);
        spriteHeart3.color = new Color(1f,1f,1f, 1f);
    }
}
