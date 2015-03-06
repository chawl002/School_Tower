using UnityEngine;
using System.Collections;

public class CrammerSpeed : MonoBehaviour {
	

	// Use this for initialization
	void Start () {

		GetComponent<EnemyMove> ().speed -= 0.01f;
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<EnemyMove> ().speed += 0.00005f;
	
	}
}
