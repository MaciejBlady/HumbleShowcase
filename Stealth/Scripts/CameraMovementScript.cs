using UnityEngine;
using System.Collections;

public class CameraMovementScript : MonoBehaviour {
	public float angleSpeed = 1.0f;

	private bool rotationSwitch = false;
	public float angleCounter = 0.0f;
	public float maxRotation = 30.0f; 



	// Use this for initialization
	void Start () {
		transform.Rotate (0,maxRotation/2.0f,0);
	}
	
	// Update is called once per frame
	void Update () {

		if (rotationSwitch) {
			transform.Rotate (0, angleSpeed * Time.deltaTime, 0);
			angleCounter += angleSpeed * Time.deltaTime;
			if (angleCounter >= maxRotation) {
				angleCounter = 0;
				rotationSwitch = false;
			}
		} else {
			transform.Rotate (0, -angleSpeed * Time.deltaTime, 0);
			angleCounter += angleSpeed * Time.deltaTime;
			if (angleCounter >= maxRotation) {
				angleCounter = 0;
				rotationSwitch = true;
			}
		}

	}
}
