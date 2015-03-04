using UnityEngine;
using System.Collections;

public class HM_VisionAlert : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 cen = new Vector2 ();
		
		cen.x = transform.position.x;
		cen.y = transform.position.y;
		
		Collider2D[] hitColliders = Physics2D.OverlapCircleAll (cen, 1.9f);//GetComponent<CircleCollider2D>().radius);
		
		for (int i=0; i < hitColliders.Length; ++i) {
			if(hitColliders[i].tag == "tower" && hitColliders[i].GetComponent<TowRunOff>().seen == false)
			{
				hitColliders[i].GetComponent<TowRunOff>().charged = true;
				hitColliders[i].GetComponent<TowRunOff>().seen = true;
			}
			
		}
		
		//CHECK FOR TOWERS FROM HERE
		
	}
}


