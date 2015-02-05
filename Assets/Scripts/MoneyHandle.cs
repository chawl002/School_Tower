using UnityEngine;
using System.Collections;

public class MoneyHandle : MonoBehaviour {

	public int mon;
	public float temp = 0;
	public int mtemp = 0;
	public GUIStyle guicust;

	// Use this for initialization
	void Start () {
		mon = 150;
	}
	
	// Update is called once per frame
	void Update () {
		temp += Time.deltaTime;
		if ((temp-mtemp)%8 > 0) { //$1 given every 5 seconds
						mtemp += 6;
						mon += 100;
				}

		

	}

	void OnGUI()
	{
		string extraZ = "";
		if (mon % 100 < 10)
						extraZ = "0";
		GUI.Label (new Rect (-50, 0, Screen.width, Screen.height), "$ " + (mon/100).ToString() + "." + extraZ + (mon%100).ToString(), guicust);
	}
}
