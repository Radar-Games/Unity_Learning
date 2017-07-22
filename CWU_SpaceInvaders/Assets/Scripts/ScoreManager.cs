using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 120, 20), score.ToString());
    }
}
