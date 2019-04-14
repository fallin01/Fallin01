using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScreen : MonoBehaviour
{


    public void next()
    {
        SceneManager.LoadScene(1);
    }

}