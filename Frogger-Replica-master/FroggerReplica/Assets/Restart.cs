using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Restart : MonoBehaviour
{
    public void StartGame()
        {
            SceneManager.LoadScene("Main_Menu");

        }
    
}

