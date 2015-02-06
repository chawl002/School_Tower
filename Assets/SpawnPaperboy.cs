using UnityEngine;
using System.Collections;

public class SpawnPaperboy : MonoBehaviour {

	bool fclick = false;
	bool sclick = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver() {
		//If unit is clicked, destroy it
		
		if (Input.GetMouseButtonDown (0) && fclick == false) {
			fclick = true;
		} 
		else if (Input.GetMouseButtonDown (0) && fclick == true && sclick == true) {
			fclick = false;
			sclick = false;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			Vector3 pos = new Vector3(ray.origin.x, ray.origin.y, -0.2f);
			Instantiate(Resources.Load("LINK 1"), pos, transform.rotation);
		}
		else if (Input.GetMouseButtonDown (0) && fclick == true) {
			sclick = true;
		}

	}
}
