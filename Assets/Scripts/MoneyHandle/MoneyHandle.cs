using UnityEngine;
using System.Collections;

public class MoneyHandle : MonoBehaviour {

	public int mon = 100;
	public float timerf = 0;
	public int timers = 0;
	public int timerm = 0;
	public bool victory = false;
	public string LoadNext = "GameSelection";
	public int MoneyAllowance = 100;
	public int AllowanceInterval = 8;

	public float temp = 0;
	public int mtemp = 0;
	public GUIStyle guicust;
	public GameObject muse;

	// Use this for initialization
	void Start () {
		muse = GameObject.Find("Musical");
	}
	
	// Update is called once per frame
	void Update () {

		if (mon <= 100)
			muse.GetComponent<AudioSource> ().pitch = 1.5f;
		else
			muse.GetComponent<AudioSource> ().pitch = 1f;


		if(mon <= 0)
			Application.LoadLevel(3);

		timerf += Time.deltaTime;

		timers = (int)(timerf - (timerf % 1));

		if (timers >= 60) {
						timers = 0;
						timerf = 0;
						timerm += 1;
				}

		temp += Time.deltaTime;
		if ((temp-mtemp)%AllowanceInterval > 0) { //MoneyAllowance given every 5 seconds
						mtemp += AllowanceInterval;
						mon += MoneyAllowance;
				}

		if (timerm >= 3)
			Application.LoadLevel(LoadNext);

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
