using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GUIStyle guicust;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnGUI()
	{
		//string mextraZ = "";
		//if (mon % 100 < 10)
		//	mextraZ = "0";
		//string textraZ = "";
		//if (timers < 10)
		//	textraZ = "0";
		GUI.color = Color.red;
		GUI.Label (new Rect (-50, 0, 0, 0), "Q - Quit\nR - Retry" , guicust);
	}
}
