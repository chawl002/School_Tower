using UnityEngine;
using System.Collections;

public class FItAllUp : MonoBehaviour {

	public GameObject moni;
	int weap = -1;



	// Use this for initialization
	void Start () {


		moni = GameObject.Find ("money");
		
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

				if(i == 0)
					moni.GetComponent<KeepTrack>().Gum = 1;
				if(i == 1)
					moni.GetComponent<KeepTrack>().Pap = 1;
				if(i == 2)
					moni.GetComponent<KeepTrack>().Bas = 1;
				if(i == 3)
					moni.GetComponent<KeepTrack>().Dog = 1;
				if(i == 4)
					moni.GetComponent<KeepTrack>().Pla = 1;
				if(i == 5)
					moni.GetComponent<KeepTrack>().Can = 1;
				if(i == 6)
					moni.GetComponent<KeepTrack>().Tac = 1;
				if(i == 7)
					moni.GetComponent<KeepTrack>().Eff = 1;


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
