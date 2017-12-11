using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag ("Player")) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex -5);
		}
	}
}
