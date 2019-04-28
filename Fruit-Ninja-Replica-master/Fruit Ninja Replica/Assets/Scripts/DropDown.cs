using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DropDown : MonoBehaviour
{
    public Dropdown fruitSize;
    public Dropdown spawningSpeed;
    public Dropdown speedFruit;
    public Dropdown otherFruit;
    public Dropdown gravity;
    public Dropdown bladeSize;

    public Text fruitSizeText;
    public Text spawningSpeedText;
    public Text speedFruitText;
    public Text otherFruitText;
    public Text gravityText;
    public Text bladeSizeText;

    static public float SpawningSpeed = 1f;
    static public float SpeedFruit = 1f;
    static public Vector2 Speedfruit;
    static public Vector3 FruitSize;
    static public float BladeSize = .1f;
    


    public void Update()
    {
        
        switch(fruitSize.value)
        {
            case 1:
                fruitSizeText.text = "Small";
                FruitSize = new Vector3(.3f, .3f, 1);
                break;
            case 2:
                fruitSizeText.text = "Medium";
                FruitSize = new Vector3(.6f, .6f, 1);
                break;
            case 3:
                fruitSizeText.text = "Large";
                FruitSize = new Vector3(1, 1, 1);
                break;
            default:
                fruitSizeText.text = "Fruit Size";
                FruitSize = new Vector3(1, 1, 1);
                break;
        }
        switch(spawningSpeed.value)
        {
            case 1:
                spawningSpeedText.text = "Slow";
                SpawningSpeed = 1f;
                break;
            case 2:
                spawningSpeedText.text = "Medium";
                SpawningSpeed = .5f;
                break;
            case 3:
                spawningSpeedText.text = "Fast";
                SpawningSpeed = .10f;
                break;
            default:
                spawningSpeedText.text = "Spawing Speed";
                SpawningSpeed = 1f;
                break;
        }
        switch (speedFruit.value)
        {
            case 1:
                speedFruitText.text = "Slow";
                Speedfruit = new Vector2(.5f, .5f);
                //SpeedFruit = 5f;
                break;
            case 2:
                speedFruitText.text = "Medium";
                Speedfruit = new Vector2(1f, 1f);
                //SpeedFruit = 10f;
                break;
            case 3:
                speedFruitText.text = "Fast";
                Speedfruit = new Vector2(2f, 2f);
                //SpeedFruit = 15f;
                break;
            default:
                speedFruitText.text = "Fruit Speed";
                //SpeedFruit = 10f;
                Speedfruit = new Vector2(1f, 1f);
                break;
        }
       switch(otherFruit.value)
        {
            case 1:
                otherFruitText.text = "No";
                OrangeSpawner.orange = false;
                KiwiSpawner.Kiwi = false;
                break;
            case 2:
                otherFruitText.text = "Orange";
                OrangeSpawner.orange = true;
                KiwiSpawner.Kiwi = false;
                break;
            case 3:
                otherFruitText.text = "Kiwi";
                OrangeSpawner.orange = false;
                KiwiSpawner.Kiwi = true;
                break;
            case 4:
                otherFruitText.text = "All";
                OrangeSpawner.orange = true;
                KiwiSpawner.Kiwi = true;
                break;
            default:
                otherFruitText.text = "Other Fruit";
                OrangeSpawner.orange = false;
                KiwiSpawner.Kiwi = false;
                break;
        }
        switch(gravity.value)
        {
            case 1:
                gravityText.text = "Low";
                Fruit.startForce = 10f;
                break;
            case 2:
                gravityText.text = "Medium";
                Fruit.startForce = 15;
                break;
            case 3:
                gravityText.text = "High";
                Fruit.startForce = 20f;
                break;
            default:
                gravityText.text = "Gravity";
                Fruit.startForce = 15f;
                break;
        }
        switch(bladeSize.value)
        {
            case 1:
                bladeSizeText.text = "Small";
                BladeSize = .1f;
                break;
            case 2:
                bladeSizeText.text = "Medium";
                BladeSize = .3f;
                break;
            case 3:
                bladeSizeText.text = "Large";
                BladeSize = .6f;
                break;
            default:
                bladeSizeText.text = "Blade Size";
                BladeSize = .3f;
                break;
        }
    }

}
