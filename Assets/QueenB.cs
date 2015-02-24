using UnityEngine;
using System.Collections;

public class QueenB : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<EnemyHP> ().HP--;
		GetComponent<EnemyMove> ().speed = GetComponent<EnemyMove> ().speed * 1.8f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
