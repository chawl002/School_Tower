using UnityEngine;
using System.Collections;

public class EnemyHP : MonoBehaviour {
	public int HP = 4;
	bool dropmon = false;

	// Use this for initializ
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (HP <= 0 && !dropmon) {
			Debug.Log(Application.loadedLevel);
					Vector3 pos = new Vector3(transform.position.x, transform.position.y, -0.2f);
					if(Application.loadedLevelName == "ElementaryLevelOne" || Application.loadedLevelName == "ElementaryEntryLevel") //ElementaryLevelOne
						Instantiate(Resources.Load("E_droppedmoney"), pos, transform.rotation);
					else if(Application.loadedLevelName == "HighSchoolLevel") //HighschoolLevel
						Instantiate(Resources.Load("H_droppedmoney"), pos, transform.rotation);
					else if(Application.loadedLevelName == "CollegeLevel") //CollegeLevel STILL NEED TO CHANGE VALUE!!
						Instantiate(Resources.Load("H_droppedmoney"), pos, transform.rotation);
					dropmon = true;
				}

		if (HP <= 0 && GetComponent<RunOff>().ranaway) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "attack") {
			if(other.name != "GUM(Clone)" && other.name != "Candy(Clone)" && other.name != "Dodgeball(Clone)")
			{
				HP = HP - other.gameObject.GetComponent<damage>().damag;
			}

			if(other.name == "Dodgeball(Clone)")
			{
				HP = HP - 1;
			}


			if(other.name != "baseball(Clone)")
				Destroy (other.gameObject);
		}

		//if (other.name == "LINK2(Clone)" || other.name == "droppedmoney(Clone)") 
		else {
						Debug.Log ("WHAT");
						Physics2D.IgnoreCollision (collider2D, other.collider2D);
				}
	}

	void OnCollisionStay2D(Collision2D coll)
	{
		Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}

}
