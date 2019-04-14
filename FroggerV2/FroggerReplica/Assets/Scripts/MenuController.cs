using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    

    public void nextScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void infoScene()
    {
        SceneManager.LoadScene("Info");
    }
    public void menuScene()
    {
        SceneManager.LoadScene("Menu");
    }
  
}

