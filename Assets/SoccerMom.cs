using UnityEngine;
using System.Collections;

public class SoccerMom : MonoBehaviour {
	
	public bool is_mad = false;
	public AudioSource aud_pain;
	bool audioplay = false;
	
	// Use this for initialization
	void Start () {
		
		GetComponent<EnemyMove> ().damageval = 0.0f;
		aud_pain = (AudioSource)gameObject.AddComponent ("AudioSource");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "attack" && other.name != "GUM(Clone)" && GetComponent<EnemyMove>().speed != 0f) {

			if(audioplay == false)
			{
				AudioClip myAudioClip;
				myAudioClip = (AudioClip)Resources.Load ("Sounds/Psycho Scream-SoundBible.com-1441943673");

				aud_pain.clip = myAudioClip;

				aud_pain.Play();
			}

			is_mad = true;
			GetComponent<EnemyMove>().damageval = 0.25f;
			GetComponent<EnemyMove>().speed = 0.3f;
		}
	}
}


