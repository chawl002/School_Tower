using UnityEngine;
using System.Collections;

public class HM_VisionFade : MonoBehaviour {
	
	private Color ourColor;
	private Color color = new Color();
	
	// Use this for initialization
	void Start () {
		ourColor = renderer.material.GetColor("_Color");
		color.r = ourColor.r;
		color.g = ourColor.g;
		color.b = ourColor.b;
		color.a = 0.33f;
		
		renderer.material.SetColor ("_Color", color);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
