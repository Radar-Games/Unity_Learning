using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public int pointValue;

    void OnTriggerEnter()
    {
        ScoreManager.score += pointValue;
    }
}
