using UnityEngine;

public class XStatement {
	public XActor actor {get; set;} 
	public XVerb verb {get; set;} 
	public XObject obj {get; set;} 

	public XStatement () {
		actor = null;
		verb = null;
		obj = null;
	}

	public XStatement(XActor actor, XVerb verb, XObject obj) {
		this.actor = actor;
		this.verb = verb;
		this.obj = obj;
	}

	public string toJSONstring () {
		return "{" + actor.toJSONstring() + ", " + 
			verb.toJSONstring() + "," + 
			obj.toJSONstring() + 
			"}";
	}
}