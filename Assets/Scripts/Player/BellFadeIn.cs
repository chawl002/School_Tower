using UnityEngine;
using System.Collections;

public class BellFadeIn : MonoBehaviour {

	private Color ourColor;
	private Color color = new Color();
	public bool ready = false;

	// Use this for initialization
	void Start () {
		ourColor = renderer.material.GetColor("_Color");
		color.r = ourColor.r;
		color.g = ourColor.g;
		color.b = ourColor.b;
		color.a = 0.6f;

		renderer.material.SetColor ("_Color", color);

	}
	
	// Update is called once per frame
	void Update () {

		if (color.a == 1)
						color.a = 0.6f;

		if (!ready) {
						color.a += 0.03f * (float)Time.deltaTime;
						if(color.a >= 1)
						{
							color.a = 1;
							renderer.material.SetColor ("_Color", color);
							ready = true;
						}

						renderer.material.SetColor ("_Color", color);
				}


	}
}
