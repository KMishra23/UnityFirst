using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int starCounter = 0;
    Text Score;

    void Start()
    {
        Score = GetComponent<Text>();
    }

    void Update()
    {
        Score.text = "Stars collected " + starCounter;
    }
}
