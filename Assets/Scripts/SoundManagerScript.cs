using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip clickSound, killSound,deathMonsterSound, deathPlayerSound, damagePlayerSound, harvestSound, victorySound;
    public static AudioClip click, kill, deathMonster, deathPlayer, damagePlayer, harvest, victory;
    public static AudioSource audioSrc;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        audioSrc = this.GetComponent<AudioSource>();   
        click = clickSound;
        kill = killSound;
        deathMonster = deathMonsterSound;
        deathPlayer = deathPlayerSound;
        damagePlayer = damagePlayerSound;
        harvest = harvestSound;
        victory = victorySound;
    }

    public static void PlaySound(string clip){
        switch(clip){
            case "kill":
                audioSrc.PlayOneShot(kill);
                break;
            case "click":
                audioSrc.PlayOneShot(click);
                break;
            case "deathMonster":
                audioSrc.PlayOneShot(deathMonster);
                break;
            case "damagePlayer":
                audioSrc.PlayOneShot(damagePlayer);
                break;
            case "deathPlayer":
                audioSrc.PlayOneShot(deathPlayer);
                break;
            case "harvest":
                audioSrc.PlayOneShot(harvest);
                break;
            case "victory":
                audioSrc.PlayOneShot(victory);
                break;
        }
        
    }
}
