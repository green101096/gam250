using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour

{
	public int index; // setting a public int allows me to call a scene from within the inspector.

	void OnTriggerEnter (Collider col) // this is saying that this script will activate if a object is collided with
	{
		if (col.tag == "Player") 
		{
			SceneManager.LoadScene (index); // this part of the script is where i can load different scenes from with this game
		}
	}
}
