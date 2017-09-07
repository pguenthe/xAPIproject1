using UnityEngine;

[System.Serializable]

public class xStatement {
	public xActor actor;
	public xVerb verb;
	public xObject obj;

	public xStatement(xActor actor, xVerb verb, xObject obj) {
		this.actor = actor;
		this.verb = verb;
		this.obj = obj;
	}
}