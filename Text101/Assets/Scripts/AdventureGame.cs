﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

	// Use this for initialization
	void Start ()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageState();
	}

    private void ManageState()
    {
        var nextState = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[2];
        }

        textComponent.text = state.GetStateStory();
    }
}
