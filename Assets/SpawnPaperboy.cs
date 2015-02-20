using UnityEngine;
using System.Collections;

public class SpawnPaperboy : MonoBehaviour {

	bool fclick = false;
	bool sclick = false;
	float temp = 0;
	public bool poop = false;
	public int ItemIndex;
	public GameObject Inv; // = GameObject.Find("Intentory");
	public GameObject Id; // = GameObject.Find("Item Database");


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Inv = GameObject.Find("Intentory");
		Id = GameObject.Find("Item Database");
		ItemIndex = Inv.GetComponent<Inventory> ().SPAWNTOWER;

		if (fclick == true) {
			temp += Time.deltaTime;
			if(temp >= 1)
			{
				temp = 0;
				fclick = false;
				sclick = false;
			}
		}
	
	}

	void OnMouseOver() {
		//If unit is clicked, destroy it

		if (ItemIndex != -1) {
		
						if (Input.GetMouseButtonDown (0) && fclick == false) {
								fclick = true;
						} else if (Input.GetMouseButtonDown (0) && fclick == true && sclick == true) {
								fclick = false;
								sclick = false;
								Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

								Vector3 pos = new Vector3 (ray.origin.x, ray.origin.y, -0.2f);
								Instantiate (Resources.Load ("Towers/" + Id.GetComponent<ItemDatabase>().items[ItemIndex].ItemName), pos, transform.rotation);
				//Debug.Log (Id.GetComponent<ItemDatabase>().items[ItemIndex].ItemName);
								poop = true;
						} else if (Input.GetMouseButtonDown (0) && fclick == true) {
								sclick = true;
						}
				}

	}
}
