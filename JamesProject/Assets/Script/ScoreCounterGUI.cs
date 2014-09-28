using UnityEngine;
using System.Collections;

public class ScoreCounterGUI : MonoBehaviour {

	public Transform gManTrans;
	private GameManager gMan;

	void Start () 
	{
		gMan = gManTrans.GetComponent<GameManager>();
	}
	

	void Update () 
	{
		guiText.text = gMan.getScoreString ();
	}
}
