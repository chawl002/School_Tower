﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	public Texture btnMenu;
	public Texture btnLevel;
	
	public float widthPercent = 0.25f;
	public float heightPercent = 0.25f;
	
	void OnGUI() {
		if (!btnMenu) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (!btnLevel) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		Rect r = new Rect(220f,
		                  150f,
		                  Screen.width * widthPercent,
		                  Screen.height * heightPercent); 
		Rect r2 = new Rect(500f,
		                   225f,
		                   Screen.width * widthPercent,
		                   Screen.height * heightPercent); 
		
		if (GUI.Button(r, btnMenu, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel(0);
		}
		if (GUI.Button(r2, btnLevel, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel(1);
		}
	}
}