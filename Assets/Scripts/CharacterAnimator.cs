using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    public RuntimeAnimatorController farmer;
    public RuntimeAnimatorController warrior;
    public Animator animator;

    void Update()
    {
        if (CharacterController.warriorSwap == false){
            animator.runtimeAnimatorController = farmer as RuntimeAnimatorController;
        }
        else if (CharacterController.warriorSwap == true){
            animator.runtimeAnimatorController = warrior as RuntimeAnimatorController;
        }
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
