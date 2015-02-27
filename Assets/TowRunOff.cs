using UnityEngine;
using System.Collections;

public class TowRunOff : MonoBehaviour {

	public bool ranaway = false;
	public bool seen = false;
	public bool charged = false;
	GameObject moni;
	GameObject IDat;
	
	float temp = 0;

	// Use this for initialization
	void Start () {
		moni = GameObject.Find ("money");
		IDat = GameObject.Find ("Item Database");
	}
	
	// Update is called once per frame
	void Update () {

		if (seen) {
			temp += Time.deltaTime;
			
			if (temp >= 0.75)
				ranaway = true;
			
			
			transform.Translate (11 * Time.deltaTime, 11 * Time.deltaTime, 0);
		}	

		if (charged) {

			moni.GetComponent<MoneyHandle>().mon -= IDat.GetComponent<ItemDatabase>().items[GetComponent<AssignWeap>().ItemIndexInInventory].itemCost;
			charged = false;
					
				}


		if (ranaway) {
					Destroy(gameObject);

				}
	
	}
}
