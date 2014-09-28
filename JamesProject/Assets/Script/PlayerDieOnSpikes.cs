using UnityEngine;
using System.Collections;

public class PlayerDieOnSpikes : MonoBehaviour {

	Vector3 currentCheckpointPos;

	void Start()
	{
		currentCheckpointPos = transform.position;
	}
	void Update () 
	{
		if(Physics2D.OverlapCircle(transform.position, .7f, 1 <<LayerMask.NameToLayer("Hazards"))) 
		{
			transform.position = currentCheckpointPos;
		}
		else if(Physics2D.OverlapCircle(transform.position, .7f, 1 <<LayerMask.NameToLayer("Checkpoints"))) 
		{
			currentCheckpointPos = Physics2D.OverlapCircle(transform.position, .7f, 1 <<LayerMask.NameToLayer("Checkpoints")).transform.position;
		}
	}
}
