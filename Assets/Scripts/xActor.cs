using UnityEngine;

[System.Serializable]

public class xActor  {
	public string name;
	public string mbox;

	public xActor (string name, string mbox) {
		this.name = name;
		this.mbox = mbox;
	}
}