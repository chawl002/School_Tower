using UnityEngine;
using System.Collections;

public class Prof_pow : MonoBehaviour {

	public GameObject money;
	public GameObject inventory;

	// Use this for initialization
	void Start () {

		money = GameObject.Find ("money");
		GetComponent<EnemyHP> ().HP += 2;
		inventory = GameObject.Find ("Inventory");
	}
	
	// Update is called once per frame
	void Update () {

		if(GetComponent<EnemyHP>().HP <= 0)
		{
			inventory.GetComponent<Inventory>().unlocked = true;
			money.GetComponent<FDefeated> ().Defeat = true;
		}
	
	}
}
