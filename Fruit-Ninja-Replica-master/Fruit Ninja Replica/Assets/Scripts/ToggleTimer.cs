using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTimer : MonoBehaviour
{
    public static float timeLimit;

    public void oneMin()
    {
        timeLimit = 60f;
    }
    public void fiveMin()
    {
        timeLimit = 300f;
    }
    public void infiniteTime()
    {
        timeLimit = 86400f;
    }
}
