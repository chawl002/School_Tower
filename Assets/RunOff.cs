using UnityEngine;
using System.Collections;

public class RunOff : MonoBehaviour {

	public bool ranaway = false;
	float temp = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GetComponent<EnemyHP> ().HP <= 0) {
						temp += Time.deltaTime;

						if (temp >= 0.75)
								ranaway = true;


						transform.Translate (11 * Time.deltaTime, 11 * Time.deltaTime, 0);
				}	
	}
}
