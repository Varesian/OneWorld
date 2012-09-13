using UnityEngine;
using System.Collections;

public class SkyboxFadeIn : MonoBehaviour {
	
	public float fadeInSpeed = 0.05f;
	public string key = "D";
	public Color startColor = Color.black;
	public Color stopColor = Color.gray;
	private float lerpAmount = 0;
	private bool update = false;
	
	// Use this for initialization
	void Start() {
		RenderSettings.skybox = new Material(RenderSettings.skybox);
		RenderSettings.skybox.SetColor("_Tint", startColor);
	}
	
	// Update is called once per frame
	void Update () {
		if (update) {
			if (lerpAmount < 1.0f) {
				Debug.Log("Updating lerp: " + lerpAmount, this);
				lerpAmount += fadeInSpeed * Time.deltaTime;
				//RenderSettings.skybox.color = Color.Lerp(Color.black, Color.white, lerpAmount);
				RenderSettings.skybox.SetColor("_Tint", Color.Lerp(startColor, stopColor, lerpAmount));
				//RenderSettings.skybox.SetColor("_Tint", Color.blue);
				
			}
		}
	}
	
	void OnGUI() {
		if (Event.current.Equals(Event.KeyboardEvent(key))) {
			update = !update;
		}
	}
	
	
}
