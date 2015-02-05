using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour {
	// spawn a new teddy each ... seconds
	public float interval = 3.0f;
	float timeLeft = 0.0f;

	
	// gameobject to be spawned
	public GameObject enemy = null;
	
	// Update is called once per frame
	void Update () {
		// time to spawn the next one?
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0.0f) {
			// spawn
			GameObject g = (GameObject)Instantiate(enemy, transform.position, Quaternion.identity);
			
			// reset time
			timeLeft = interval;
		}
	}

}