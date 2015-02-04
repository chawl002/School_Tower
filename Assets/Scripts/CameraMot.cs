using UnityEngine;
using System.Collections;

public class CameraMot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("w"))
			Camera.main.transform.Translate (0f, 0.20f, 0f);
		if (Input.GetKeyDown ("a"))
			Camera.main.transform.Translate (-0.20f, 0f, 0f);
		if (Input.GetKeyDown ("s"))
			Camera.main.transform.Translate (0f, -0.20f, 0f);
		if (Input.GetKeyDown ("d"))
			Camera.main.transform.Translate (0.20f, 0f, 0f);
	}
}
