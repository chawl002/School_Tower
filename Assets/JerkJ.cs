using UnityEngine;
using System.Collections;

public class JerkJ : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<EnemyHP> ().HP = GetComponent<EnemyHP> ().HP+3;
		GetComponent<EnemyMove> ().speed = GetComponent<EnemyMove> ().speed * 0.8f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
