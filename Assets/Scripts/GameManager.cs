using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager gm;

	public string activityID = "http://www.pguenther.com/activities/unity/testproj1";
	public string activityName = "Test Project 1";

	public InputField emailField;
	public InputField nameField;

	[HideInInspector]
	public string username = "";

	[HideInInspector]
	public string mbox = "";

	void Start() {
		gm = this;
	}

	void Update() {
		username = nameField.text; 
		mbox= emailField.text;
	}
}
