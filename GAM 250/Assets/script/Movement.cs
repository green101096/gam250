using UnityEngine;
using System.Collections;


public class Movement : MonoBehaviour 
{
	public float movement = 10; 
	public float ForceOfJump = 50;
	public float gravity = 10;
	private Vector3 movingDirection = Vector2.zero;
	CharacterController CC;

	void Start()
	{
		CC = GetComponent<CharacterController> ();
	}
	void Update()
	{

		if (CC.isGrounded) 
		{
			movingDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			movingDirection = transform.TransformDirection (movingDirection);
			movingDirection *= movement;
			if (Input.GetButton ("Jump"))
				movingDirection.y = ForceOfJump;
		}
		movingDirection.y -= gravity * Time.deltaTime;
		CC.Move (movingDirection * Time.deltaTime);
	}
}