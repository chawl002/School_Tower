using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject musical;

	// Use this for initialization
	void Start () {

		musical = GameObject.Find ("Musical");
	
	}
	
	// Update is called once per frame
	void Update () {

				if (Input.GetKeyDown ("space")) {
		
						if (Time.timeScale == 1) {
								Time.timeScale = 0;
				musical.GetComponent<AudioSource>().Pause();
								
						}

						else {
								Time.timeScale = 1;
				musical.GetComponent<AudioSource>().Play();
						}
				}
		}
		
	}
