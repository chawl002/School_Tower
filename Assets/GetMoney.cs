using UnityEngine;
using System.Collections;

public class GetMoney : MonoBehaviour {
	public int plus = 15;
	float temp = 0;
	private Color ourColor;
	private Color color = new Color();
	bool doFade = false;

	// Use this for initialization
	void Start () {
		ourColor = renderer.material.GetColor("_Color");
		color.r = ourColor.r;
		color.g = ourColor.g;
		color.b = ourColor.b;
		color.a = ourColor.a;
	}
	
	// Update is called once per frame
	void Update () {
		//fade out when doFade set to true
		if (doFade) {
						color.a -= 0.5f * (float)Time.deltaTime;
						renderer.material.SetColor ("_Color", color);
				}

		//If faded completely, Destroy
		if (ourColor.a <= 0)
						Destroy (gameObject);

		//After 5 seconds, indicate to start fading
		temp += Time.deltaTime;
		if (temp >= 5) {
			doFade = true;
				}
	
	}

	void OnMouseOver() {
		//If unit is clicked, destroy it
		if (Input.GetMouseButtonDown (0)) {
						GameObject.Find("money").GetComponent<MoneyHandle>().mon += plus;
						Destroy (gameObject);
				}
	}
}
