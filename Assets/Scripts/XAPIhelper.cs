using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class XAPIhelper : MonoBehaviour {
	void Start () {
//		xActor actor = new xActor ("Peter Guenther", "peter.guenther@gmail.com");
//		xVerb verb = new xVerb("http://adlnet.gov/expapi/verbs/completed", "completed");
//		xObject obj = new xObject("http://nonsense.net", "Some Nonsense");
//
//		xStatement statement = new xStatement (actor, verb, obj);
//
//		string json = JsonUtility.ToJson (statement);

		string json = "{\"actor\": {\"name\": \"Sally Glider\",\"mbox\": \"mailto:sally@example.com\"}," +
		              "\"verb\": {\"id\": \"http://adlnet.gov/expapi/verbs/experienced\",\"display\": { \"en-US\": \"experienced\" }}," +
		              "\"object\": {\"id\": \"http://example.com/activities/solo-hang-gliding\",\"definition\": {" +
		              "\"name\": { \"en-US\": \"Solo Hang Gliding\" }" + "} } }";
		
		StartCoroutine(SaveData (json));

	}

	IEnumerator SaveData(string json) {
		Debug.Log ("JSON: " + json);

		string auth = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(XAPIcredentials.KEY + ":" + XAPIcredentials.SECRET));
		Debug.Log (auth);

		using (UnityWebRequest www = UnityWebRequest.Post(XAPIcredentials.ENDPOINT, "")) {
			//UnityWebRequest's Post method expects form data; we need to use an upload handler for the raw JSON
			UploadHandlerRaw upload= new UploadHandlerRaw(Encoding.UTF8.GetBytes(json));
			www.uploadHandler= upload;

			www.SetRequestHeader("X-Experience-API-Version", "1.0.0");
			www.SetRequestHeader("Authorization", auth);
			www.SetRequestHeader("Content-Type", "application/json");

			Debug.Log ("Contacting server...");
			Debug.Log (www.ToString ());

			yield return www.Send();

			if (www.isError)
			{
				Debug.Log(www.error);
			}
			else
			{
				Debug.Log("Success! " + www.responseCode);
			}
		}	
	}
}