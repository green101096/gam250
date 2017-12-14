using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
	public void OnClick()// this is checking that something has been clicked, once it has this script will activate
	{
		Application.Quit(); // this ends the play seasson
	}
}
