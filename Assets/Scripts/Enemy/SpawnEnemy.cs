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
	public GameObject enemy4 = null;
	public GameObject enemy5 = null;
	public GameObject enemy6 = null;

	public int spawn1 = 100;
	public int spawn2 = 10;
	public int spawn3 = 0;
	public int spawn4 = 0;
	public int spawn5 = 0;
	public int spawn6 = 0;
	
	// Update is called once per frame
	void Update () {
		// time to spawn the next one?
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0.0f) {
			// spawn
			//int random =rand();
			GameObject enemy = enemy1;
			float rander = Random.Range(0, 100);
			if(rander <= spawn2 && enemy2 != null)
				enemy = enemy2;

			rander = Random.Range (0,100);
			if(rander <= spawn3 && enemy3!=null)
				enemy = enemy3;
			rander = Random.Range (0,100);
			if(rander <= spawn4 && enemy4!=null)
				enemy = enemy4;
			rander = Random.Range (0,100);
			if(rander <= spawn5 && enemy5!=null)
				enemy = enemy5;
			rander = Random.Range (0,100);
			if(rander <= spawn6 && enemy6!=null)
				enemy = enemy6;

			GameObject g = (GameObject)Instantiate(enemy, transform.position, Quaternion.identity);
			
			// reset time
			timeLeft = interval;
			decreaseIntervalTmp -= 0.5f;
			if(decreaseIntervalTmp <= 0f){
				if(interval > 1.0f){
					interval -= 1.0f;
				}
				decreaseIntervalTmp = decreaseInterval;
			}
		}
	}

}