using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {

	public int damag = 0;
	//public GameObject itemdat;

	// Use this for initialization
	void Start () {

		//itemdat = GameObject.FindWithTag ("Item Database");

		damag = GetComponent<ProjPro> ().damage;
		//Debug.Log ("My damage is " + damag);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
