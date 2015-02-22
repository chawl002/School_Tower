using UnityEngine;
using System.Collections;

public class BellReady : MonoBehaviour {

	private Color ourColor;
	private Color color = new Color();
	float roti = 0.075f;
	Vector3 Rot = new Vector3();
	bool rotfin = false;
	int rotdir = 1;
	bool mover = false;
	public bool clicked = false;
	public int rate = 2;
	float temp = 0;
	bool fadeAudio = false;

	// Use this for initialization
	void Start () {

		Rot.x = 0;
		Rot.y = 0;
		Rot.z = 1;

	}
	
	// Update is called once per frame
	void Update () {

		ourColor = renderer.material.GetColor("_Color");

		if (clicked) {
					if(!audio.isPlaying)
						audio.Play();

					temp+= Time.deltaTime;

					if(temp >= 2)
					{
						clicked = false;
						GetComponent<BellFadeIn>().ready = false;

						color.r = ourColor.r;
						color.g = ourColor.g;
						color.b = ourColor.b;
						color.a = 0.6f;
						renderer.material.SetColor ("_Color", color);

						if (transform.rotation.z != 0)
							transform.rotation = Quaternion.identity;
						
						temp = 0;

						fadeAudio = true;

					}


				}

		if (fadeAudio) {
					
			audio.volume -= 0.1f;
			if(audio.volume <=0)
			{
				audio.Stop();
				audio.volume = 1.0f;
				fadeAudio = false;
			}

				}

		if (ourColor.a == 1) {


						if (rotfin == true) {

								roti = -1 * roti;
								rotdir = -1 * rotdir;
								rotfin = false;
						}

						//if(mover)
			if(clicked== true)
			{
				rate = 8;
			}
							transform.Rotate (Rot * rotdir*rate);
			rate = 1;

						//else
						//	transform.Rotate (Rot * rotdir);

						if (GetComponent<Transform> ().rotation.z * GetComponent<Transform> ().rotation.z >= roti * roti)
								rotfin = true;


						mover = false;

				}

	
	}

	void OnMouseOver()
	{
		if (ourColor.a == 1) {
						mover = true;
						rate++;
				}
		if (Input.GetMouseButtonDown (0) && ourColor.a == 1) {
						clicked = true;
				} 
	}
}
