using UnityEngine;
using System.Collections;

public class PositionLerper : MonoBehaviour {
	
	public Vector3 endingPosition;
	public float movementSpeed = 0.05f;
	public string key = "A";
	public bool setStartPositionWhenKeyPressed = true;
	public bool disableMeshRenderedAfterMoved = false;
	private Vector3 startPosition;
	private float lerpAmount = 0;
	private bool update = false;
	private bool meshRendererDisabled = false;
	
	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (update) {
			if (lerpAmount < 1.0f) {
				lerpAmount += movementSpeed * Time.deltaTime;
				transform.localPosition = Vector3.Lerp(startPosition, endingPosition, lerpAmount);
			} else {
				if (!meshRendererDisabled && disableMeshRenderedAfterMoved) {
					renderer.enabled = false;
					meshRendererDisabled = true;
				}
			}
		}
	}
	
	void OnGUI() {
		if (Event.current.Equals(Event.KeyboardEvent(key))) {
			if (setStartPositionWhenKeyPressed) {
				startPosition = transform.localPosition;
			}
			update = !update;
		}
	}
}
