using UnityEngine;
using System.Collections;

public class DestroyOnClick : MonoBehaviour {
		
	bool fclick = false;

	float temp = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fclick == true) {
				temp += Time.deltaTime;
				if(temp >= 0.5)
				{
					temp = 0;
					fclick = false;
				}

				if(Input.GetKeyDown("w"))
				{
					fclick = false;
					Debug.Log("up");
				}

				if(Input.GetKeyDown("a"))
				{
					fclick = false;
					Debug.Log("left");
				}

				if(Input.GetKeyDown("s"))
				{
					fclick = false;
					Debug.Log("down");
				}

				if(Input.GetKeyDown("d"))
				{
					fclick = false;
					Debug.Log("right");
				}

			}

	}

	void OnMouseOver() {
		//If unit is clicked, destroy it

		if (Input.GetMouseButtonDown (0) && fclick == false) {
						fclick = true;
				} 
		else if (Input.GetMouseButtonDown(0) && fclick == true) {
	
						Destroy(gameObject);
				}
	}
}
