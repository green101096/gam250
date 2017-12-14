using UnityEngine;
using System.Collections;


public class Movement : MonoBehaviour 
{
	// these are all my variables for this script
	public float movement = 10; 
	public float ForceOfJump = 50;
	public float gravity = 10;
	private Vector3 movingDirection = Vector2.zero;
	CharacterController CC;


	void Start()
	{
		CC = GetComponent<CharacterController> ();
	}
	// in this part of the script i am calling the character componant 
	void Update()
	{
		//for this i am checking that the player is grounded this stops the player from floating out of the scene
		if (CC.isGrounded) 
		{
			// this part of the script allows the player to move around on the x, y and z axis
			movingDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			movingDirection = transform.TransformDirection (movingDirection);
			movingDirection *= movement;
			// this part of the script states that if the space button is pressed then a force will push them up.
			if (Input.GetButton ("Jump"))
				movingDirection.y = ForceOfJump;
		}
		movingDirection.y -= gravity * Time.deltaTime;
		CC.Move (movingDirection * Time.deltaTime);
	}
}