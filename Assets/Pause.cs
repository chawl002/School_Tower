﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

				if (Input.GetKeyDown ("space")) {
		
						if (Time.timeScale == 1) {
								Time.timeScale = 0;
						}

						else {
								Time.timeScale = 1;
						}
				}
		}
		
	}
