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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
