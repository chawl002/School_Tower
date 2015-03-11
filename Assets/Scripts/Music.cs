using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Music : MonoBehaviour {

	public static Music instance = null;

	void Start() 
	{
		audio.loop = true;
		audio.rolloffMode = AudioRolloffMode.Custom;
		if (!instance.audio.playOnAwake)
			audio.Play ();

	}

	void Awake()
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
	}
}

