using UnityEngine;
using System.Collections;

public class HM_Follow : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//transform.Translate(0, 0, 0);
		
	}
	
	void OnCollisionStay2D(Collision2D coll)
	{
		Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}
}