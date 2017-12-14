using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour

{
	public int index; 

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player") 
		{
			SceneManager.LoadScene (index);
		}
	}
}
