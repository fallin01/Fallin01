using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    public Dropdown CarSpeed;
    public Dropdown FrogSize;
    public Dropdown CarSize;
    public Dropdown SpawnSpeed;

    
 

    static public float cSpeed = 0f;
    static public float fSize = 0f;
    static public float cSize = 0f;                                                                                                       
    static public float sSpeed = 0f;

    void Update()
    {
     switch (CarSpeed.value)
        {
            case 1:

                cSpeed = 5f;
                break;
            case 2:
                
                cSpeed = 10f;
                break;
            case 3:
                
                cSpeed = 15f;
                break;
            default:
                
                cSpeed = 15f;
                break;
        }
        switch (FrogSize.value)
        {
            case 1:
                
                fSize = .5f;
                break;
            case 2:
               
                fSize = .7f;
                break;
            case 3:
               
                fSize = 1f;
                break;
            default:
                
                fSize = 1f;
                break;
        }
        switch (CarSize.value)
        {
            case 1:
                
                cSize = .5f;
                break;
            case 2:
                
                cSize = .7f;
                break;
            case 3:
                
                cSize = 1f;
                break;
            default:
                
                cSize = 1f;
                break;

        }
        switch (SpawnSpeed.value)
        {
            case 1:
               
                sSpeed = 5f;
                break;
            case 2:
                
                sSpeed = 10f;
                break;
            case 3:
                
                sSpeed = 15f;
                break;
            default:
                
                sSpeed = 15f;
                break;
        }
    }
}
