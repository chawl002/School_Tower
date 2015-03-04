using UnityEngine;
using System.Collections;

public class CookieMove : MonoBehaviour {

	public Vector2 dirt;
	float tempi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		tempi += Time.deltaTime;
		if (tempi >= 2)
						Destroy (gameObject);




		transform.Translate(Time.deltaTime*dirt.x*4, Time.deltaTime*dirt.y*4, 0);
	
	}
}
