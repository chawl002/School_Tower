/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BellReady_1 : MonoBehaviour 
{
	private Color ourColor;
	private Color color = new Color();
	private float roti = 0.075f;
	private Vector3 Rot = new Vector3();
	private bool rotfin = false;
	private int rotdir = 1;
	public bool mover = false;
	public bool clicked = false;
	public int rate = 2;
	float temp = 0;
	bool fadeAudio = false;

	//used to instanciate random events when bell is clicked
	public int max = 3; //max size of EventDatabase list (calling item from 
	private int rand_event; //event value number in list
	private bool bell_event = true; //controls number of times rand function is called

	// Use this for initialization
	void Start () {

		Rot.x = 0;
		Rot.y = 0;
		Rot.z = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		ourColor = renderer.material.GetColor("_Color");

		if (clicked) 
		{
			//play the bell ring noise
			if(!audio.isPlaying)
			{audio.Play();}

			//pick a random event to execute once
			if(bell_event)
			{	
				rand_event = Random.Range(0, max);
				//Debug.Log(rand_event);
				bell_event = false;
			}

			//updates time variable
			temp+= Time.deltaTime;
			//if the noise has played for 2 seconds, shut down.
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
				{transform.rotation = Quaternion.identity;}
				
				temp = 0;
				bell_event = true;
				fadeAudio = true;

			}
		}

		if (fadeAudio) 
		{
			audio.volume -= 0.1f;
			if(audio.volume <=0)
			{
				audio.Stop();
				audio.volume = 1.0f;
				fadeAudio = false;
			}

		}

		if (ourColor.a == 1) 
		{
			if (rotfin == true) {

					roti = -1 * roti;
					rotdir = -1 * rotdir;
					rotfin = false;
			}

			if(clicked == true)
			{
				rate = 8;
			}

			transform.Rotate (Rot * rotdir*rate);
			rate = 1;

			if (GetComponent<Transform> ().rotation.z * GetComponent<Transform> ().rotation.z >= roti * roti)
			{rotfin = true;}

			mover = false;
		}
	}

	//check to see if user has clicked the bell
	void OnMouseOver()
	{
		if (ourColor.a == 1) 
		{
			mover = true;
			rate++;
		}
		if (Input.GetMouseButtonDown (0) && ourColor.a == 1) 
		{
			clicked = true;
		} 
	}
}*/
