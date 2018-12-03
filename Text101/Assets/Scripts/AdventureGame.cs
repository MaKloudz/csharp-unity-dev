using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

	// Use this for initialization
	void Start () {
        textComponent.text = "Placeholder story text";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
