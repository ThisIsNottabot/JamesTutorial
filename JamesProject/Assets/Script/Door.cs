using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public int sceneDest = 0;

	void OnTriggerStay2D( Collider2D col )
	{
		if(Input.GetKey("e"))
		{
			Application.LoadLevel ("scene" + sceneDest.ToString("00"));
		}
	}
}
