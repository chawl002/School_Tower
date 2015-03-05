using UnityEngine;
using System.Collections;

public class ReseachRunOff : MonoBehaviour {

	public bool ranaway = false;
	bool droppedPot = false;

	GameObject poti;
	
	float temp = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GetComponent<EnemyHP> ().HP <= 0) {

			if(droppedPot == false)
			{
			Vector3 pos = new Vector3(transform.position.x, transform.position.y, -0.01f);
			Instantiate(Resources.Load("Potio"), pos, transform.rotation);
			droppedPot = true;
			}


		}	
	}
}
