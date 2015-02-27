using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour {
	// spawn a new teddy each ... seconds
	public float interval = 3.0f;
	public float decreaseInterval = 3.0f;
	private float decreaseIntervalTmp;
	float timeLeft = 0.0f;

	void Start() {
		decreaseIntervalTmp = decreaseInterval;
	}
	
	// gameobject to be spawned

	public GameObject enemy1 = null;
	public GameObject enemy2 = null;
	public GameObject enemy3 = null;
	
	// Update is called once per frame
	void Update () {
		// time to spawn the next one?
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0.0f) {
			// spawn
			//int random =rand();
			GameObject enemy = enemy1;
			float rander = Random.Range(0, 30);

			if(rander >= 26 && enemy2!=null)
				enemy = enemy2;

			GameObject g = (GameObject)Instantiate(enemy, transform.position, Quaternion.identity);
			
			// reset time
			timeLeft = interval;
			decreaseIntervalTmp -= 1.0f;
			if(decreaseIntervalTmp <= 0f){
				if(interval > 1.0f){
					interval -= 1.0f;
				}
				decreaseIntervalTmp = decreaseInterval;
			}
		}
	}

}