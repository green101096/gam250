using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManagement : MonoBehaviour
{
	public void LoadByIndex(int sceneIndex) // this loads a scene based on which i select
	{
		SceneManager.LoadScene (sceneIndex); // this loads it by build order
	}
}