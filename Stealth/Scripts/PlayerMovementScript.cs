using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
	public float playerSpeed = 10.0f;
	public float mouseRotationSpeed = 360.0f;
	private CharacterController controller;
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		float horizontalMove = Input.GetAxis ("Horizontal");
		float verticalMove = Input.GetAxis ("Vertical");
		float horizontalRotate = Input.GetAxis ("Mouse X");

		transform.Rotate(0,horizontalRotate*mouseRotationSpeed*Time.deltaTime,0);

		Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= playerSpeed;

		controller.Move(moveDirection * Time.deltaTime);

		//if (transform.position.y != 0.0f)

	}
}
