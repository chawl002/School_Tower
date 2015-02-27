using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour {
	public Transform[] waypoints;
	public GameObject healthBar;
	public int cur = 0;
	float temp = 0;
	public Vector2 lastpos;
	public Vector2 deltapos;
	public float damageval = 0.25f;
	
	public float speed = 0.015f;
	
	void Start()
	{
		lastpos.x = transform.position.x;
		lastpos.y = transform.position.y;
		
		deltapos.x = 0;
		deltapos.y = 0;
	}
	
	
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
			healthBar = GameObject.Find("HealthBar");
			healthBar.GetComponent<Image>().fillAmount -= damageval;
			Destroy(this.gameObject);
			if(healthBar.GetComponent<Image>().fillAmount == 0){
				Application.LoadLevel(3);
			}
		}
		// Waypoint reached, select next one
		else {
			cur = cur + 1;
		}
		
		//GUM
		if (speed == 0) {
			
			temp += Time.deltaTime;
			
			if(temp >= 2.2)
			{
				speed = 0.015f;
				temp = 0;
			}
		}
		
		deltapos.x = transform.position.x - lastpos.x;
		deltapos.y = transform.position.y - lastpos.y;
		
		
		lastpos.x = transform.position.x;
		lastpos.y = transform.position.y;
		
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

