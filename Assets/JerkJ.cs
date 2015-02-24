using UnityEngine;
using System.Collections;

public class JerkJ : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<EnemyHP> ().HP = GetComponent<EnemyHP> ().HP+4;
		GetComponent<EnemyMove> ().speed = GetComponent<EnemyMove> ().speed * 0.75f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
