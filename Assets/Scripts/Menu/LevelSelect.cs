using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	public Texture btnEle;
	public Texture btnBack;
	
	public float widthPercent = 0.15f;
	public float heightPercent = 0.15f;
	
	void OnGUI() {
		if (!btnEle) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (!btnBack) {
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

		if (GUI.Button(r, btnEle, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("ElementaryLevelOne");
		}
		if (GUI.Button(r2, btnBack, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("OpeningTitle");
		}
	}
}
