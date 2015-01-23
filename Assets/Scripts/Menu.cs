using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture btnTexture;
	
	public float widthPercent = 0.3f;
	public float heightPercent = 0.3f;
	public float movex = 350f;
	public float movey = 150f;

	void OnGUI() {
		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		Rect r = new Rect(movex,
		                  movey,
		                  Screen.width * widthPercent,
		                  Screen.height * heightPercent); 

		if (GUI.Button(r, btnTexture, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("GameSelection");
		}
	}
}