using UnityEngine;
using System.Collections;

public class IndexInList : MonoBehaviour {

	public int INDEX;

	// Use this for initialization
	void Start () {

		INDEX = GetComponentInParent<AssignWeap> ().ItemIndexInInventory;
		//Debug.Log ("I am a " + name + " and my index is " + INDEX);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
