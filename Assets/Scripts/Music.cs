using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Music : MonoBehaviour {

	public static Music instance = null;

	void Start() 
	{
		audio.loop = true;
		audio.rolloffMode = AudioRolloffMode.Custom;
		audio.maxDistance = 1000;
		audio.minDistance = 100;
		if (!instance.audio.playOnAwake)
			audio.Play ();

	}

	/*void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}*/
}

