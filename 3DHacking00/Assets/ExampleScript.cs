using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	float x;

	// Update is called once per frame
	void Update () {
	    
	    x += Mathf.Repeat(Time.deltaTime * 10, 360);
	    gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0,x,x);

		if (Input.GetKeyDown (KeyCode.R)) {
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			gameObject.GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
