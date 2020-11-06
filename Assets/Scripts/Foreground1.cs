using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground1 : MonoBehaviour
{
    Transform background;
    Vector3 original = new Vector3(-24.84f, 1.566751f, -5f);
    Vector3 finalPos = new Vector3(2.354823f, 1.566751f, -5f);
    int counter = 100;
    // Start is called before the first frame update
    void Start()
    {
        background = this.transform;
        original = background.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 increment = new Vector3(0.001f, 0f, 0f);
        while(counter > 0){
            background.position += increment * Time.deltaTime;
            counter -= 1;
            if (background.position == finalPos){
                background.position = original;
            }
        }
        counter = 100;
        
        
    }
}
