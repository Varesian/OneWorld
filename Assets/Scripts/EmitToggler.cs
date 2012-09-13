using UnityEngine;
using System.Collections;

public class EmitToggler : MonoBehaviour {
	
	public ParticleEmitter pe;
	public string key = "F";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (Event.current.Equals(Event.KeyboardEvent(key))) {
			pe.emit = !pe.emit;
		}
	}
}
