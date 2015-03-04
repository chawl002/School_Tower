using UnityEngine;
using System.Collections;

public class GirlScouting : MonoBehaviour {


	public GameObject cook;
	public GameObject cookClone;
	float timex = 0;


	
	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		timex += Time.deltaTime;

		if (timex >= 2) {
		
						Vector3 pos = transform.position;
		
						cookClone = Instantiate (cook, pos, transform.rotation) as GameObject; //Instantiate(tragedy);
						
						cookClone.GetComponent<CookieMove>().dirt.x = GetComponent<EnemyMove>().dir.x;
						cookClone.GetComponent<CookieMove>().dirt.y = GetComponent<EnemyMove>().dir.y;

						if (cookClone.GetComponent<CookieMove>().dirt.x == 0 && cookClone.GetComponent<CookieMove>().dirt.y == 0)
							Destroy (cookClone);

						timex = 0;

				}
		
	}
}
