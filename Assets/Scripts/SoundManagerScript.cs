using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip deathMonsterSound, deathPlayerSound, damagePlayerSound, harvestSound, victorySound;
    public static AudioClip deathMonster, deathPlayer, damagePlayer, harvest, victory;
    public static AudioSource audioSrc;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        audioSrc = this.GetComponent<AudioSource>();   
        deathMonster = deathMonsterSound;
        deathPlayer = deathPlayerSound;
        damagePlayer = damagePlayerSound;
        harvest = harvestSound;
        victory = victorySound;
    }

    public static void PlaySound(string clip){
        switch(clip){
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
