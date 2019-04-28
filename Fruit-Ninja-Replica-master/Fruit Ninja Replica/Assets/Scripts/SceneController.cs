using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void dropdownNext()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        SceneManager.LoadScene("EndScreen");
    }
    public void replay()
    {
        SceneManager.LoadScene("Main");
    }
    public void backtostart()
    {
        SceneManager.LoadScene("DropDown");
    }
    public void endgame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void scoreScreen()
    {
        SceneManager.LoadScene("LastScreen");
    }
}
