﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool toggle;
    public bool paused;
    private PlayerHealth healthPoints;
    bool alive = true;
    
    void Awake()
    {
        healthPoints = GameObject.Find("MBTHull").GetComponent<PlayerHealth>();
    }
    // Update is called once per frame
    void Update()
    {
        if(healthPoints.pHealth < 0f)
        {
            alive = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
        }

        if(toggle == true && !paused && alive)
        {
            PauseToggleTrue();
        }
        if(toggle == false && paused && alive)
        {
            PauseToggleFalse();
        }
    }

    void PauseToggleTrue()
    {
        Time.timeScale = 0f;
        paused = true;
    }

    void PauseToggleFalse()
    {
        Time.timeScale = 1f;
        paused = false;
    }
}
