using UnityEngine;
using System.Collections;

public class SoccerMom : MonoBehaviour {

	bool trig = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "attack" && other.name != "GUM(Clone)" && GetComponent<EnemyMove>().speed != 0f) {
			trig = true;
			GetComponent<EnemyMove>().speed = 0.3f;
		}
	}
}
