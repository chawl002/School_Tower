using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public Transform[] waypoints;
	int cur = 0;
	
	public float speed = 0.3f;
	
	void FixedUpdate () {
		// Waypoint not reached yet? then move closer
		if (transform.position != waypoints [cur].position) {
			Vector2 p = Vector2.MoveTowards (transform.position,
			                                waypoints [cur].position,
			                                speed);
			rigidbody2D.MovePosition (p);
		} 
		// Last Waypoint reached, destroy enemy
		else if (cur == waypoints.Length - 1) {
			Destroy(this.gameObject);
		}
		// Waypoint reached, select next one
		else {
			cur = cur + 1;
		}

	}
}
