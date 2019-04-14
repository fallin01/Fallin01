using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOptions : MonoBehaviour
{
    public Dropdown Car; //size of car
    public Dropdown Frog; //size of frog 
    public Dropdown Speed; //speed of car
    public Dropdown Spawn; //spawn speed of car

    static public float spawn = 15f;
    static public float car = 1f;
    static public float frog = 1f;
    static public float speed = 15f;


    public void Update()
    {
        switch(Frog.value)
        {
            case 1:
                frog = .5f;
                break;
            case 2:
                frog = .7f;
                break;
            case 3:
                frog = 1f;
                break;
            default:
                frog = 1f;
                    break;
        }
        switch(Spawn.value)
        {
            case 1:
                spawn = 5f;
                break;
            case 2:
                spawn = 10f;
                break;
            case 3:
                spawn = 15f;
                break;
            default:
                spawn = 15f;
                break;
        }
        switch(Car.value)
        {
            case 1:
                car = .5f;
                break;
            case 2:
                car = .7f;
                break;
            case 3:
                car = 1f;
                break;
            default:
                car = 1f;
                break;
        }
        switch (Speed.value)
        {
            case 1:
                speed = 5f;
                break;
            case 2:
                speed = 10f;
                break;
            case 3:
                speed = 15f;
                break;
            default:
                speed = 15f;
                break;
        }
    }


}
