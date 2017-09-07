using UnityEngine;

[System.Serializable]

public class xObject {
	public string id;
	public string definition;

	public xObject (string id, string definition) {
		this.id = id;
		this.definition = definition;
	}
}