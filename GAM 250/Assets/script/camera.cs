//using UnityEngine;
//using System.Collections;
//
//public class camera : MonoBehaviour
//{
//	public float LookingVerticallySpeed = 8f;
//	public float LookingHorizontalSpeed = 8f;
//
//	private float turning = 0f;
//	private float pitch = 0f;
//
//	// Update is called once per frame
//	void Update () 
//	{
//		turning += LookingHorizontalSpeed * Input.GetAxis ("Mouse X");
//		pitch -= LookingVerticallySpeed* Input.GetAxis ("Mouse Y");
//
//		transform.eulerAngles = new Vector3 (pitch, turning, 0.0f);
//	}
//}
