using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreCount;
    int score = 0;
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreCount.text = score.ToString();
    }

    public void AddScore()
    {
        score += 1;
        scoreCount.text = score.ToString();
    }
}
