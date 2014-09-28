using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public bool gamePaused;
	private int score = 0;

	void Update () 
	{
		if(Input.GetButtonDown("Pause"))
		{
			gamePaused = !gamePaused;
		}

		if(score > 6)
		{
			Application.LoadLevel("scene02");
		}
	}

	public void IncreaseScore( int x )
	{
		score += x;
	}

	public string getScoreString()
	{
		return score.ToString ();
	}
}
