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
	
	public float speed = 0.005f;

	public float sspeed = 0.005f;

	public Vector2 dir; //direction enemy is facing

	public static int sceneLevel;
	
	void Start()
	{
		lastpos.x = transform.position.x;
		lastpos.y = transform.position.y;
		
		deltapos.x = 0;
		deltapos.y = 0;

		Vector2 fWP;
		Vector2 face;
		
		fWP.x = waypoints[cur].GetComponent<Transform>().position.x;
		fWP.y = waypoints[cur].GetComponent<Transform>().position.y;
		
		face.x = fWP.x - GetComponent<Transform>().position.x;
		face.y = fWP.y - GetComponent<Transform>().position.y;

		if (face.x * face.x >= face.y * face.y) {
			if (face.x > 0) {
				//GetComponent<SpriteRenderer>().transform.Rotate(0, 180, 0);
				dir.x = 1;
				dir.y = 0;
			} else {
				dir.x = -1;
				dir.y = 0;
			}
		} else {
			if (face.y > 0) {
				//GetComponent<SpriteRenderer>().transform.Rotate(0, 180, 0);
				dir.y = 1;
				dir.x = 0;
			} else {
				dir.y = -1;
				dir.x = 0;
			}
		}

	}
	
	
	void FixedUpdate () {



		
		//fix spinning on enemies
		if (transform.rotation.z != 0)
			transform.rotation = Quaternion.identity;
		// Waypoint not reached yet? then move closer
		if (transform.position.x != waypoints [cur].position.x || transform.position.y != waypoints [cur].position.y) {

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
				if (Application.loadedLevelName == "ElementaryEntryLevel"){
					sceneLevel = 0;
				}
				if (Application.loadedLevelName == "ElementaryLevelOne"){
					sceneLevel = 1;
				}
				if (Application.loadedLevelName == "HighSchoolLevel"){
					sceneLevel = 2;
				}
				if (Application.loadedLevelName == "CollegeLevel"){
					sceneLevel = 3;
				}
				Application.LoadLevel("GameOver");

			}
		}
		// Waypoint reached, select next one
		else {

			//Debug.Log("reach this");

			Vector2 currentWP;
			Vector2 nextWP;
			Vector2 vect;
			
			currentWP.x = waypoints[cur].GetComponent<Transform>().position.x;
			currentWP.y = waypoints[cur].GetComponent<Transform>().position.y;
			
			nextWP.x = waypoints[cur+1].GetComponent<Transform>().position.x;
			nextWP.y = waypoints[cur+1].GetComponent<Transform>().position.y;
			
			vect.x = nextWP.x - currentWP.x;
			vect.y = nextWP.y - currentWP.y;
			
			if (vect.x * vect.x >= vect.y * vect.y) {
				if (vect.x > 0) {
					//GetComponent<SpriteRenderer>().transform.Rotate(0, 180, 0);
					dir.x = 1;
					dir.y = 0;
				} else {
					dir.x = -1;
					dir.y = 0;
				}
			} else {
				if (vect.y > 0) {
					//GetComponent<SpriteRenderer>().transform.Rotate(0, 180, 0);
					dir.y = 1;
					dir.x = 0;
				} else {
					dir.y = -1;
					dir.x = 0;
				}
			}

			cur = cur + 1;
		}
		
		//GUM
		if (speed == 0) {
			
			temp += Time.deltaTime;
			
			if(temp >= 2.2)
			{
				speed = sspeed;
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
			sspeed = speed;
			speed = 0f;
		}

		if (other.name == "Candy" || other.name == "Candy(Clone)") {
						Destroy (other.gameObject);
						speed = speed/1.75f;
				}

		if (other.name == "Potio" || other.name == "Potio(Clone)" && GetComponent<EnemyHP>().HP != 0) {
			
			Destroy (other.gameObject);
			speed = speed * 2f;
			GetComponent<EnemyHP>().HP += 2;

		}

		if (other.name == "Tackker" || other.name == "Tackker(Clone)") {
						Destroy(other.gameObject);
						GetComponent<EnemyHP> ().HP -= 1;
						speed = speed / 1.25f;
				}

		
	}


	
}

