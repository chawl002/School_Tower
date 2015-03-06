using UnityEngine;
using System.Collections;

public class RunOff : MonoBehaviour {

	public bool ranaway = false;
	public AudioSource aud_feet;
	public AudioSource aud_pain;
	bool audioplay = false;
	bool audiopain = false;

	float temp = 0;

	// Use this for initialization
	void Start () {

		aud_feet = (AudioSource)gameObject.AddComponent ("AudioSource");
		aud_pain = (AudioSource)gameObject.AddComponent ("AudioSource");

	}
	
	// Update is called once per frame
	void Update () {

		if (GetComponent<EnemyHP> ().HP <= 0) {

			if(audioplay == false)
			{
				AudioClip myAudioClip;
				myAudioClip = (AudioClip)Resources.Load ("Sounds/running_feet_-Cam-942211296");

				AudioClip myAudioClip2;
				myAudioClip2 = (AudioClip)Resources.Load ("Sounds/Pain-SoundBible.com-1883168362");


				aud_pain.clip = myAudioClip2;

				aud_pain.pitch += 1;

				aud_pain.Play();

				aud_feet.clip = myAudioClip;

				aud_feet.Play();



				audioplay = true;
			}
						
						temp += Time.deltaTime;

						if (temp >= 0.75)
								ranaway = true;


						transform.Translate (11 * Time.deltaTime, 11 * Time.deltaTime, 0);
				}	
	}
}
