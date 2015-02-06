using UnityEngine;
using System.Collections;

public class MoneyHandle : MonoBehaviour {

	public int mon;
	public float timerf = 0;
	public int timers = 0;
	public int timerm = 0;
	public bool victory = false;

	public float temp = 0;
	public int mtemp = 0;
	public GUIStyle guicust;

	// Use this for initialization
	void Start () {
		mon = 150;
	}
	
	// Update is called once per frame
	void Update () {

		timerf += Time.deltaTime;

		timers = (int)(timerf - (timerf % 1));

		if (timers >= 60) {
						timers = 0;
						timerf = 0;
						timerm += 1;
				}

		Debug.Log (timers);

		temp += Time.deltaTime;
		if ((temp-mtemp)%8 > 0) { //$1 given every 5 seconds
						mtemp += 6;
						mon += 100;
				}

		if (timerm >= 3)
						victory = true;

	}

	void OnGUI()
	{
		string mextraZ = "";
		if (mon % 100 < 10)
						mextraZ = "0";
		string textraZ = "";
		if (timers < 10)
						textraZ = "0";
		GUI.Label (new Rect (-50, 0, Screen.width, Screen.height), "\n$ " + (mon/100).ToString() + "." + mextraZ + (mon%100).ToString() + "\n\n\n\n" + timerm.ToString() + ":" + textraZ + timers.ToString(), guicust);
	}
}
