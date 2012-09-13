using UnityEngine;
using System.Collections;

public class PositionLerpLooper : MonoBehaviour
{
	
	public Vector3 endingPosition;
	public float movementSpeed = 0.05f;
	private Vector3 startPosition;
	private float lerpAmount = 0;
	private int direction = 1;
	
	// Use this for initialization
	void Start ()
	{
		startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update ()
	{
		lerpAmount += movementSpeed * Time.deltaTime * direction;
		if (lerpAmount > 1.0f || lerpAmount < 0.0f) {
			direction *= -1;
			lerpAmount += movementSpeed * Time.deltaTime * direction;
		}
		transform.localPosition = Vector3.Lerp (startPosition, endingPosition, lerpAmount);
	}
}
