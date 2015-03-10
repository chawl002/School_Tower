using UnityEngine;
using System.Collections;

public class FDefeated : MonoBehaviour {

	public bool Defeat = false;
	public bool unlocked = false;
	public GameObject inv;

	// Use this for initialization
	void Start () {

		inv = GameObject.Find ("Inventory");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Defeat == true && unlocked == false) {
						//Debug.Log ("UNLOCKED");
						inv.GetComponent<Inventory>().unlocked = true;
						unlocked = true;
				}
	
	}
}
