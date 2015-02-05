using UnityEngine;
using System.Collections;

public class GetMoney : MonoBehaviour {
	public int plus = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver() {
		//If unit is clicked, destroy it
		if (Input.GetMouseButtonDown (0)) {
						GameObject.Find("money").GetComponent<MoneyHandle>().mon += plus;
						Destroy (gameObject);
				}
	}
}
