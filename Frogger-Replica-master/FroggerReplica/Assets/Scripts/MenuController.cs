using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    

    public void nextScene()
    {
        SceneManager.LoadScene(2);
       
    }
    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
  
}

