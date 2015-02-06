using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture btnTexture;
	
	public float widthPercent = 0.3f;
	public float heightPercent = 0.3f;

	void OnGUI() {
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		//Position of the Play button
		Rect r = new Rect(Screen.width / 2 - (Screen.width/8), Screen.height/2, Screen.width * widthPercent, Screen.height * heightPercent); 

		if (GUI.Button(r, btnTexture, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("GameSelection");
		}
	}
}