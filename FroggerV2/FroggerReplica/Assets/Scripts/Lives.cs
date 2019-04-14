using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public static int life;

    void Start()
    {
        life = 3;
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
    }

    void Update()
    {
        if(life > 3)
        {
            life = 3;
            switch(life)
            {
                case 3:
                    life1.gameObject.SetActive(true);
                    life2.gameObject.SetActive(true);
                    life3.gameObject.SetActive(true);
                    break;
                case 2:
                    life1.gameObject.SetActive(true);
                    life2.gameObject.SetActive(true);
                    life3.gameObject.SetActive(false);
                    break;
                case 1:
                    life1.gameObject.SetActive(true);
                    life2.gameObject.SetActive(false);
                    life3.gameObject.SetActive(false);
                    break;
                case 0:
                    life1.gameObject.SetActive(false);
                    life2.gameObject.SetActive(false);
                    life3.gameObject.SetActive(false);
                    break;

            }
        }
    }
}
