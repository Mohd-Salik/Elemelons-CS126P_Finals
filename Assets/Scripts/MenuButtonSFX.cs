using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonSFX : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip click;

    public void Hovering(){
        sound.PlayOneShot(click);
    }

    public void Clicking(){
        sound.PlayOneShot(click);
    }
}
