using UnityEngine;
using System.Collections;

public class SpawnPaperboy : MonoBehaviour {

	//First click
	bool fclick = false;
	float temp = 0;//counts time between clicks

	public bool poop = false;//Has the tower been paced yet?
	public GameObject Inv; // = GameObject.Find("Intentory");
	public GameObject Id; // = GameObject.Find("Item Database");
	public GameObject money;

	//public int thresh = 10;
	//public int count = 0;

	// Use this for initialization
	void Start () {
		Inv = GameObject.Find("Inventory");
		Id = GameObject.Find("Item Database");
		money = GameObject.Find ("money");

	
	}
	
	// Update is called once per frame
	void Update () {
		//time between clicks - checks to make sure double clicks are within the same second
		//Debug.Log (Inv.GetComponent<Inventory> ().SPAWNTOWER);

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
		//Debug.Log (Inv.GetComponent<Inventory> ().SPAWNTOWER);
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
				bool dont = false;
				fclick = false;
					
				//place the tower at ray/vector
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				Vector3 pos = new Vector3 (ray.origin.x, ray.origin.y, -0.2f);
				//place tower
				if(money.GetComponent<KeepTrack> ().Gum == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "BubbleGumGirl")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Pap == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "PaperwadBoy")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Dog == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "DodgeballGirl")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Pla == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "PaperplaneGirl")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Eff == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "ProfessorF")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Can == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "CandyKid")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Tac == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "TackKid")
					dont = true;
				if(money.GetComponent<KeepTrack> ().Bas == 1 && Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image == "BaseballBoy")
					dont = true;

				if(!dont)
				Instantiate (Resources.Load ("Towers/" + Id.GetComponent<ItemDatabase>().items[Inv.GetComponent<Inventory> ().SPAWNTOWER].player_image), pos, transform.rotation);

				//reset variables after tower is placed
				poop = true;


			}
		
		}

	}
}
