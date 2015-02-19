using UnityEngine;
using System.Collections;

public class ProjPro : MonoBehaviour {
	
	public float temp = 0;
	//public GameObject proj;
	public GameObject money;

	// Use this for initialization
	void Start () {
		money = GameObject.Find ("money");
		if (money.GetComponent<MoneyHandle> ().mon - 15 < 0)
			Destroy (gameObject);
		else
			money.GetComponent<MoneyHandle>().mon -= 15;
		/*if (Input.GetKey (KeyCode.UpArrow)) {
			a = 1.0f;
			b = 0;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			a = -1.0f;	
			b =0;
		} else if ((Input.GetKey (KeyCode.RightArrow))) {
			a = 0;
			b = 0;
		}*/
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(8*Time.deltaTime, 0, 0);
		//transform.position = Vector2.MoveTowards(transform.position, , 8 * Time.deltaTime);

		temp += Time.deltaTime;
		if (temp > 1.2) {
			Destroy(gameObject);
		}
		
		//Debug.Log (temp);
		//if (Input.GetKeyDown ("x"))
		//				break;
	}

}