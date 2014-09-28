using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public Transform gManTrans;
	private GameManager gMan;
	public int value;

	void Start () 
	{
		gMan = gManTrans.GetComponent<GameManager> ();
	}

	void OnTriggerEnter2D( Collider2D col )
	{
		gMan.IncreaseScore(value);
		Destroy (gameObject);
	}
}
