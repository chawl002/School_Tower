using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject musical;
	public bool pause = false;

	// Use this for initialization
	void Start () {

		musical = GameObject.Find ("Musical");
	
	}
	
	// Update is called once per frame
	void Update () {

				if (Input.GetKeyDown ("space")) {
		
						if (Time.timeScale == 1) {
								Time.timeScale = 0;
				musical.GetComponent<AudioSource>().volume = 0.3f;
				musical.GetComponent<AudioSource>().pitch = musical.GetComponent<AudioSource>().pitch/1.5f;
				pause = true;
								
						}

						else {
								Time.timeScale = 1;
				musical.GetComponent<AudioSource>().volume = 1f;
				musical.GetComponent<AudioSource>().pitch = musical.GetComponent<AudioSource>().pitch*1.5f;
				pause = false;
						}
				}
		}
		
	}
