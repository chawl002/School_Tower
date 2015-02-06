using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	private double timer = 30;
	public bool IsTiming = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if (IsTiming) {
			timer -= Time.deltaTime;		
		}
		if (timer <= 0) {
			Application.LoadLevel(3);		
		}
	}
}
