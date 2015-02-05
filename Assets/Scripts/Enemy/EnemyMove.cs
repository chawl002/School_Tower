using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour {
	public Transform[] waypoints;

	int cur = 0;
	float temp = 0;
	
	public float speed = 0.015f;



	void FixedUpdate () {
		//fix spinning on enemies
		if (transform.rotation.z != 0)
						transform.rotation = Quaternion.identity;
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
			Application.LoadLevel(3);

		}
		// Waypoint reached, select next one
		else {
			cur = cur + 1;
		}

		if (speed == 0) {

			temp += Time.deltaTime;

			if(temp >= 2.2)
			{
				speed = 0.015f;
				temp = 0;
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//Respond to gum
		if (other.name == "GUM" || other.name == "GUM(Clone)") {

			Destroy (other.gameObject);
			speed = 0f;
		}
		
	}

}
