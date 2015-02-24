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

		Collider2D[] hitColliders = Physics2D.OverlapCircleAll (cen, 5);
	
		//CHECK FOR TOWERS FROM HERE

	}
}
