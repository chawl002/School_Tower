using UnityEngine;
using System.Collections;

public class TowRot : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Transform>().Rotate(0,180, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
