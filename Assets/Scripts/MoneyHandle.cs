using UnityEngine;
using System.Collections;

public class MoneyHandle : MonoBehaviour {

	public int mon;
	public float temp = 0;
	public int mtemp = 0;
	public GUIStyle guicust;

	// Use this for initialization
	void Start () {
		mon = 100;
	}
	
	// Update is called once per frame
	void Update () {
		temp += Time.deltaTime;
		if ((temp-mtemp)%5 > 0) { //$1 given every 5 seconds
						mtemp += 5;
						mon += 100;
				}

		

	}

	void OnGUI()
	{
		GUI.Label (new Rect (50, 50, Screen.width, Screen.height), "$ " + (mon/100).ToString() + " . " + (mon%100).ToString(), guicust);
	}
}
