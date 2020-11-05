using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class GFX : MonoBehaviour
{
    public AIPath aiPath;

    //if morning, destroy the object
    void Update(){
        if (Environment.nightTime == true){
            ChasePlayer();
        }
        else{
            Destroy(GameObject.Find(this.name+"(Clone)"));
        }
    }

    void ChasePlayer()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        } else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f,1f,1f);
        }
    }

}
