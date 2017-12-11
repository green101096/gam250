﻿using UnityEngine;
using System.Collections;

public class platformMovement: MonoBehaviour
{
	public Transform[] Waypoint;
	public float PlatformSpeed = 15f;
	public float RotationsSpeed = 0.5f;
	public int CurrentLocation = 0;
	private GameObject Player;

	void Update()
	{
		if (transform.position != Waypoint [CurrentLocation].transform.position) {
			//movement of the platform towards a location
			transform.position = Vector3.MoveTowards (transform.position, Waypoint [CurrentLocation].transform.position, PlatformSpeed * Time.deltaTime);

			//rotation of the movement going the other way
			transform.rotation = Quaternion.Lerp (transform.rotation, Waypoint [CurrentLocation].transform.rotation, RotationsSpeed * Time.deltaTime);

			//setting which point to start the platform movement
		}	
		if (transform.position == Waypoint [CurrentLocation].transform.position) {
			CurrentLocation += 1;
		}
		if (CurrentLocation >= Waypoint.Length) {
			CurrentLocation = 0;
		}
	}
}
