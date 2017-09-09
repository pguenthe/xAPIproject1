using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public InputField emailField;
	public InputField nameField;

	public string objectID = "http://www.pguenther.com/activities/unity/testproj1";
	public string objectName = "Test Project 1";

	void RegisterBegin () {
		string email = emailField.text;
		string name = nameField.text;
		string verbID = "http://activitystrea.ms/schema/1.0/start";
		string verbDisplay = "started";

		XStatement stmt = new XStatement ();
		stmt.actor = new XActor (name, email);
		stmt.verb = new XVerb (verbID, verbDisplay);
		stmt.obj = new XObject (objectID, objectName);
		string json = stmt.toJSONstring();

//		Debug.Log (json);

		XAPIhelper.instance.SaveStatement (json);
	}

	void RegisterFinish () {
		string email = emailField.text;
		string name = nameField.text;
		string verbID = "http://activitystrea.ms/schema/1.0/complete";
		string verbDisplay = "completed";

		XStatement stmt = new XStatement ();
		stmt.actor = new XActor (name, email);
		stmt.verb = new XVerb (verbID, verbDisplay);
		stmt.obj = new XObject (objectID, objectName);
		string json = stmt.toJSONstring();

//		Debug.Log (json);

		XAPIhelper.instance.SaveStatement (json);
	}
}
