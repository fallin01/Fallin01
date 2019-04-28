using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    public Text time;
    public float timeLeft;

    private void Update()
    {
        timeLeft = Time.deltaTime;
        time.text = (timeLeft).ToString("0");
        if(timeLeft < 0)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}
