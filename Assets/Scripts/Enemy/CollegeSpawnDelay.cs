using UnityEngine;
using System.Collections;

public class CollegeSpawnDelay : MonoBehaviour {
	
	public GameObject[] spawns;
	// Use this for initialization
	void Start () {
	
		foreach (GameObject spawn  in spawns){
			spawn.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (MoneyHandle.colleg_spawn_delay == 1) {
			foreach (GameObject spawn  in spawns){
				spawn.SetActive(true);
			}
		}
	}
}
