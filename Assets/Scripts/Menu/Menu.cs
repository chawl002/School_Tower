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
		Rect r = new Rect(350f,
		                  180f,
		                  Screen.width * widthPercent,
		                  Screen.height * heightPercent); 

		if (GUI.Button(r, btnTexture, GUIStyle.none)){
			Debug.Log("Clicked the button with an image");
			Application.LoadLevel("GameSelection");
		}
	}
}