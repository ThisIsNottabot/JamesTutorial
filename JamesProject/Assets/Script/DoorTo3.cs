using UnityEngine;
using System.Collections;

public class DoorTo3: MonoBehaviour {


	void OnTriggerStay2D( Collider2D col )
	{
		if(Input.GetKey("e"))
		{
			Application.LoadLevel ("scene03");
		}
	}
}
