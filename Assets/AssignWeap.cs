using UnityEngine;
using System.Collections;

public class AssignWeap : MonoBehaviour {

	public int ItemIndexInInventory = -1;
	public GameObject Invent;

	// Use this for initialization
	void Start () {

		Invent = GameObject.Find ("Inventory");
		ItemIndexInInventory = Invent.GetComponent<Inventory> ().SPAWNTOWER;
		Debug.Log (ItemIndexInInventory);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
