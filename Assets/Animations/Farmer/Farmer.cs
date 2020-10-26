using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
