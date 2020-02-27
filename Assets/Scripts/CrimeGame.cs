using System;
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
        for(int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        } 

        textComponent.text = state.GetStateStory();
    }
}
