using UnityEngine;
using System.Collections;

public class SoccerMom : MonoBehaviour {
	
	public bool is_mad = false;
	
	// Use this for initialization
	void Start () {
		
		GetComponent<EnemyMove> ().damageval = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "attack" && other.name != "GUM(Clone)" && GetComponent<EnemyMove>().speed != 0f) {
			is_mad = true;
			GetComponent<EnemyMove>().damageval = 0.25f;
			GetComponent<EnemyMove>().speed = 0.3f;
		}
	}
}


