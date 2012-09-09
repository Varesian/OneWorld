using UnityEngine;
using System.Collections;

public class SkyboxFadeIn : MonoBehaviour {
	
	public float fadeInSpeed = 0.05f;
	public string key = "D";
	private float lerpAmount = 0;
	private bool update = false;
	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (update) {
			if (lerpAmount < 1.0f) {
				Debug.Log("Updating lerp: " + lerpAmount, this);
				lerpAmount += fadeInSpeed * Time.deltaTime;
				//RenderSettings.skybox.color = Color.Lerp(Color.black, Color.white, lerpAmount);
				RenderSettings.skybox.color = Color.black;
				
			}
		}
	}
	
	void OnGUI() {
		if (Event.current.Equals(Event.KeyboardEvent(key))) {
			update = !update;
		}
	}
}
