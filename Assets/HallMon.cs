using UnityEngine;
using System.Collections;

public class HallMon : MonoBehaviour {
	
	public bool hasVision = false;
	
	public GameObject vis;
	public GameObject visClone;
	
	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		pos.z = -0.01f;
		
		visClone = Instantiate(vis, pos, transform.rotation) as GameObject; //Instantiate(tragedy);
		visClone.transform.parent = gameObject.transform;

		hasVision = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		/*if (GetComponent<EnemyHP> ().HP >= 0 && hasVision) {
			Destroy(visClone);
			hasVision = false;
				}*/
		
		
		
	}
}
