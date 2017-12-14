using UnityEngine;
using System.Collections;

public class seperateMovement: MonoBehaviour
{
	public Transform[] Waypoint;
	public float PlatformSpeed = 15f;
	public float RotationsSpeed = 0.5f;
	public int CurrentLocation = 0;
	private GameObject Player;

	void Update() // update calls the function every frame
	{
		if (transform.position != Waypoint [CurrentLocation].transform.position) {
			//movement of the platform towards a location
			transform.position = Vector3.MoveTowards (transform.position, Waypoint [CurrentLocation].transform.position, PlatformSpeed * Time.deltaTime);

			//rotation of the movement going the other way
			transform.rotation = Quaternion.Lerp (transform.rotation, Waypoint [CurrentLocation].transform.rotation, RotationsSpeed * Time.deltaTime);

			//setting which point to start the platform movement
		}	
		//float distanceToWaypoint = Vector3.Distance (transform.position, Waypoint [CurrentLocation].transform.position);
		//if (distanceToWaypoint<0.2f)
		if (transform.position == Waypoint [CurrentLocation].transform.position) {
			CurrentLocation += 1;
		}
		if (CurrentLocation >= Waypoint.Length) {
			CurrentLocation = 0;
		}
	}
}
