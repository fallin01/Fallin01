using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System;

public class FileScript : MonoBehaviour
{
    public Text highScores;
    public int num_scores = 5;

    public void showTopScores()
    {
        string path = Application.dataPath + "/HighScores.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[num_scores];
        int[] playerscores = new int[num_scores];
        int scores_read = 0;

        highScores.text = "";

        StreamReader reader = new StreamReader(path);

        while (!reader.EndOfStream && scores_read < num_scores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            highScores.text = fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }

    }
}
