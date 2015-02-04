using UnityEngine;
using System.Collections;


public class MovePath : MonoBehaviour {

	public float trans = 7;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		transform.Translate(trans*Time.deltaTime, 0, 0);


	}

}
