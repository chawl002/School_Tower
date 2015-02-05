using UnityEngine;
using System.Collections;

public class EnemyHP : MonoBehaviour {
	public int HP;

	// Use this for initializ
	void Start () {
		HP = 4;
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {
			Vector3 pos = new Vector3(transform.position.x, transform.position.y, -0.2f);
			Instantiate(Resources.Load("droppedmoney"), pos, transform.rotation);
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Sword" || other.name == "Sword(Clone)") {
			HP = HP - 1;
			Destroy (other.gameObject);
		}

		if (other.name == "LINK2(Clone)" || other.name == "droppedmoney(Clone)") {
						Debug.Log ("WHAT");
						Physics2D.IgnoreCollision (collider2D, other.collider2D);
				}

	}

	void OnCollisionStay2D(Collision2D coll)
	{
		Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}

}
