using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlantMechanic : MonoBehaviour
{
    public static int jumpCounter = 0, soilCounter = 0;
    float plantLastPosition;
	public Sprite soilImage;

    
	//If player moves, jump counter will reset.
    //If player jumps the same position 5 times, soil gameObject will be created.
    void Update()
    {
        if (plantLastPosition != transform.position.x)
		{
			jumpCounter = 0;
		}

        if (jumpCounter == 0)
        {
            plantLastPosition = transform.position.x;
        }
        else if (jumpCounter == 5)
        {
            CharacterPlantMechanic.soilCounter ++;
            jumpCounter = 0;
            Invoke("createSoil", 0.5f);
        }
    }

    //Create Soil Function, create sprite.
	void createSoil(){
		GameObject soil = new GameObject("Plantable Soil " + soilCounter);
		soil.transform.position = GameObject.Find(this.name+"/feet").transform.position;
		soil.transform.position += Vector3.up * .1f;
		soil.transform.localScale = new Vector3(.7f, .7f, 1f);

		SpriteRenderer soilSprite = soil.AddComponent<SpriteRenderer>();
		soilSprite.sprite = soilImage;
		soilSprite.sortingOrder = 0;
        soilSprite.sortingLayerName = "Character";
	}
}
