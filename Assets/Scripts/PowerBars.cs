using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBars : MonoBehaviour
{
    public GameObject AirIcon, WaterIcon, EarthIcon, FireIcon;

    SpriteRenderer AirSprites, WaterSprites, EarthSprites, FireSprites;

    public Sprite Air0, Air1, Air2, Air3, Air4;
    public Sprite Fire0, Fire1, Fire2, Fire3, Fire4;
    public Sprite Earth0, Earth1, Earth2, Earth3, Earth4;
    public Sprite Water0, Water1, Water2, Water3, Water4;

    void Start()
    {
        AirSprites = AirIcon.GetComponent<SpriteRenderer>();
        WaterSprites = WaterIcon.GetComponent<SpriteRenderer>();
        EarthSprites = EarthIcon.GetComponent<SpriteRenderer>();
        FireSprites = FireIcon.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        //water sprites
        if (CharacterController.waterPower == 0){
            WaterSprites.sprite = Water0;
        }
        else if (CharacterController.waterPower == 1){
            WaterSprites.sprite = Water1;
        }
        else if (CharacterController.waterPower == 2){
            WaterSprites.sprite = Water2;
        }
        else if (CharacterController.waterPower == 3){
            WaterSprites.sprite = Water3;
        }
        else if (CharacterController.waterPower == 4){
            WaterSprites.sprite = Water4;
        }

        //air sprites
        if (CharacterController.airPower == 0){
            AirSprites.sprite = Air0;
        }
        else if (CharacterController.airPower == 1){
            AirSprites.sprite = Air1;
        }
        else if (CharacterController.airPower == 2){
            AirSprites.sprite = Air2;
        }
        else if (CharacterController.airPower == 3){
            AirSprites.sprite = Air3;
        }
        else if (CharacterController.airPower == 4){
            AirSprites.sprite = Air4;
        }

        //fire sprites
        if (CharacterController.firePower == 0){
            FireSprites.sprite = Fire0;
        }
        else if (CharacterController.firePower == 1){
            FireSprites.sprite = Fire1;
        }
        else if (CharacterController.firePower == 2){
            FireSprites.sprite = Fire2;
        }
        else if (CharacterController.firePower == 3){
            FireSprites.sprite = Fire3;
        }
        else if (CharacterController.firePower == 4){
            FireSprites.sprite = Fire4;
        }

        //earth sprites
        if (CharacterController.earthPower == 0){
            EarthSprites.sprite = Earth0;
        }
        else if (CharacterController.earthPower == 1){
            EarthSprites.sprite = Earth1;
        }
        else if (CharacterController.earthPower == 2){
            EarthSprites.sprite = Earth2;
        }
        else if (CharacterController.earthPower == 3){
            EarthSprites.sprite = Earth3;
        }
        else if (CharacterController.earthPower == 4){
            EarthSprites.sprite = Earth4;
        }

    }
}
