using UnityEngine;
using System.Collections;

public class QuitorRetry : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) {
			if (Input.GetKeyDown ("q"))
			{
				Time.timeScale = 1;
				Application.LoadLevel("GameSelection");
			}

			if(Input.GetKeyDown ("r"))
			{
				Time.timeScale =1;
				Application.LoadLevel(Application.loadedLevelName);
			}

				}
	}
}
