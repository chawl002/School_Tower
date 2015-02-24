﻿using UnityEngine;
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
					Vector3 pos = new Vector3(transform.position.x, transform.position.y, -0.2f);
					Instantiate(Resources.Load("droppedmoney"), pos, transform.rotation);
					dropmon = true;
				}

		if (HP <= 0 && GetComponent<RunOff>().ranaway) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "attack") {
			if(other.name != "GUM(Clone)")
				HP = HP - 1;
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
