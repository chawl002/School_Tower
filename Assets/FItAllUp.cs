using UnityEngine;
using System.Collections;

public class FItAllUp : MonoBehaviour {

	//public GameObject moni;
	int weap = -1;
	
	// Use this for initialization
	void Start () {


		//moni = GameObject.Find ("money");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 cen = new Vector2 ();
		
		cen.x = transform.position.x;
		cen.y = transform.position.y;
		
		Collider2D[] hitColliders = Physics2D.OverlapCircleAll (cen, 0);//GetComponent<CircleCollider2D>().radius);
		
		for (int i=0; i < hitColliders.Length; ++i) {
			if(hitColliders[i].tag == "tower")
			{
				//moni.GetComponent<MoneyHandle>().mon -= 25;
				weap = hitColliders[i].GetComponent<AssignWeap>().ItemIndexInInventory;

				Debug.Log ("The weapon I destroy is " + weap);

				Destroy(hitColliders[i].gameObject);

				Destroy(gameObject);
			}
			
		}
		
	}
	
	void OnCollisionStay2D(Collision2D coll)
	{
		Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}
}
