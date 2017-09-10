using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSender : MonoBehaviour {
//	string verbID = "http://activitystrea.ms/schema/1.0/start";
//	string verbDisplay = "started";
//
//	string verbID = "http://activitystrea.ms/schema/1.0/complete";
//	string verbDisplay = "completed";

	public string verbID;
	public string verbDisplay;

	void SendStatement() {
		XStatement stmt = new XStatement ();
		stmt.actor = new XActor (GameManager.gm.username, GameManager.gm.mbox);
		stmt.verb = new XVerb (verbID, verbDisplay);
		stmt.obj = new XObject (GameManager.gm.activityID, GameManager.gm.activityName);
		string json = stmt.toJSONstring();

		Debug.Log (json);

		XAPIhelper.instance.SaveStatement (json);
	}
}
