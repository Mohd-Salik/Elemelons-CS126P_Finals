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
            if (WeaponCollider.harvestStart == true){
                animator.SetBool("harvestStart", true);
            }
            else if (WeaponCollider.harvestStart == false){
                animator.SetBool("harvestStart", false);
            }
        }
        else if (CharacterController.warriorSwap == true){
            animator.runtimeAnimatorController = warrior as RuntimeAnimatorController;
            if (CharacterController.selectedType == 0){
                animator.SetInteger("Element", 0);
            }
            else if (CharacterController.selectedType == 1){
                animator.SetInteger("Element", 1);
            }
            else if (CharacterController.selectedType == 2){
                animator.SetInteger("Element", 2);
            }
            else if (CharacterController.selectedType == 3){
                animator.SetInteger("Element", 3);
            }
            else if (CharacterController.selectedType == 4){
                animator.SetInteger("Element", 4);
            }

            if (WeaponCollider.attackStart == true){
                animator.SetBool("Attacking", true);
            }
            else if (WeaponCollider.attackStart == false){
                animator.SetBool("Attacking", false);
            }
        }
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    }
}
