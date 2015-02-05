using UnityEngine;
using System.Collections;

public class KeepTop : MonoBehaviour {

	public float camx; //= Camera.main.transform.position.x;
	public float camy; //= Camera.main.transform.position.y;

	// Use this for initialization
	void Start () {
		//transform.Translate(;
		camx = Camera.main.transform.position.x;
		camy = Camera.main.transform.position.y;
		transform.Translate(camx-transform.position.x, camy-transform.position.y, 0); // Camera.main.transform);
		transform.Translate(15, 6, 0);//Camera.main.transform);

	}
	
	// Update is called once per frame
	void Update () {

		if (Camera.main.transform.position.x != camx || Camera.main.transform.position.y != camy) {
			camx = Camera.main.transform.position.x;
			camy = Camera.main.transform.position.y;
			transform.Translate (camx-transform.position.x, camy-transform.position.y, 0); // Camera.main.transform);
			transform.Translate (15, 6, 0);// Camera.main.transform);
						

				}

	}
}
