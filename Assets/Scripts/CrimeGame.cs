﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrimeGame : MonoBehaviour { 

   [SerializeField] Text textComponent;
   [SerializeField] State startingState;


    State state;   
    void Start() {

        state = startingState;
        textComponent.text = state.GetStateStory();

        string[] nextState = { "Room1", "Room2"};
    
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageState(); 
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}
