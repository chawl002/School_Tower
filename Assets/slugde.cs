using UnityEngine;
using System.Collections;

public class slugde : MonoBehaviour {

	private Color ourColor;
	private Color color = new Color();
	
	// Use this for initialization
	void Start () {
		

		
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
				hitColliders[i].gameObject.GetComponent<DestroyOnClick>().BLOCK = true;

				ourColor = hitColliders[i].gameObject.GetComponent<SpriteRenderer>().material.GetColor("_Color");
				color.r = ourColor.r/3f;
				color.g = ourColor.g;
				color.b = ourColor.b/3f;
				color.a = ourColor.a;
				
				hitColliders[i].gameObject.GetComponent<SpriteRenderer>().material.SetColor ("_Color", color);
				
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
