using UnityEngine;
using System.Collections;

public class GumPower : MonoBehaviour {

	public float temp = 0;
	//public GameObject proj;
	public GameObject money;
	
	// Use this for initialization
	void Start () {
		//transform.Translate (0f, -1f, 0f);
		money = GameObject.Find ("money");
		if (money.GetComponent<MoneyHandle> ().mon - 25 < 0)
						Destroy (gameObject);
		else
			money.GetComponent<MoneyHandle>().mon -= 25;
	}

	// Update is called once per frame
	void Update () {
		if(temp < 0.5)
				transform.Translate(0, -0.05f, 0);

		temp += Time.deltaTime;
		if (temp >= 3) {
			Destroy(gameObject);
		}
	}
}
