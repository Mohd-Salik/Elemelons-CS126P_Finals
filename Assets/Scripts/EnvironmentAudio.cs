using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentAudio : MonoBehaviour
{
    public AudioClip daymp3;
    public AudioClip nightmp3;

    public static bool changed = false;

    void Start()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.clip = daymp3;
        audio.Play();
    }
    void Update()
    {
        if (changed == true){
            if (Environment.nightTime == true){
                GetComponent<AudioSource>().clip = nightmp3;
            }else{
                GetComponent<AudioSource>().clip = daymp3;
            }
            GetComponent<AudioSource>().Play();
            changed = false;
        }
    }
}
