using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public bool gamePaused;

	void Update () 
	{
		if(Input.GetButtonDown("Pause"))
		{
			gamePaused = !gamePaused;
		}
	}
}
