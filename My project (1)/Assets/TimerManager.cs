using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    //public static TimerManager instance;

    public Text TimeText;
    public float GameTimer;
    public bool TimerOn = false;

    //void Awake()
    //{
    //    instance = this;
    //}
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if(GameTimer > 0)
            {
                GameTimer -= Time.deltaTime;
                updateTimer(GameTimer);
            }
            else
            {
                GameTimer = 0;
                TimerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        TimeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    /*public bool checksum()
    {
        if (TimerOn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/
}