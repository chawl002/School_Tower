using UnityEngine;
using System.Collections;

public class SpawnPaperboy : MonoBehaviour {

	//First click
	bool fclick = false;
	float temp = 0;//counts time between clicks

	public bool poop = false;//Has the tower been paced yet?
	public GameObject Inv; // = GameObject.Find("Intentory");
	public GameObject Id; // = GameObject.Find("Item Database");

	//public int thresh = 10;
	//public int count = 0;

	// Use this for initialization
	void Start () {
		Inv = GameObject.Find("Inventory");
		Id = GameObject.Find("Item Database");
	
	}
	
	// Update is called once per frame
	void Update () {
		//time between clicks - checks to make sure double clicks are within the same second
		if (fclick == true) {
			temp += Time.deltaTime;
			if(temp >= 1)
			{
				temp = 0;
				fclick = false;
			}

		}
	}

	//mouseover registers where the colliders are in the map
	void OnMouseOver() {
		//If null item is clicked, do nothing
		if (Inv.GetComponent<Inventory> ().SPAWNTOWER != -1) 
		{
			//If there hasnt been a click before, it is the first click
			if (Input.GetMouseButtonDown (0) && fclick == false) {
				fclick = true;
					poop = false;
			} 
			//on double click, place tower
			else if (Input.GetMouseButtonDown (0) && fclick == true )
			{
				fclick = false;
					
				//place the tower at ray/vector
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				Vector3 pos = new Vector3 (ray.origin.x, ray.origin.y, -0.2f);
				//place tower
				Instantiate (Resources.Load ("Towers/" + Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].ItemName), pos, transform.rotation);

				//reset variables after tower is placed
				poop = true;


			}
		
		}

	}
}
