using UnityEngine;
using System.Collections;

public class PositionLerper : MonoBehaviour {
	
	public Vector3 endingPosition;
	public float movementSpeed = 0.05f;
	private Vector3 startPosition;
	private float lerpAmount = 0;
	
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (lerpAmount < 1.0f) {
			lerpAmount += movementSpeed * Time.deltaTime;
			transform.position = Vector3.Lerp(startPosition, endingPosition, lerpAmount);
		}
	}
}
