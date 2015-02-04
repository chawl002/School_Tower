using UnityEngine;
using System.Collections;

public class EnemyHP : MonoBehaviour {
	public int HP;

	// Use this for initializ
	void Start () {
		HP = 4;
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {

						Destroy (gameObject);
				}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Sword" || other.name == "Sword(Clone)") {
			HP = HP - 1;
			Destroy (other.gameObject);
		}

	}


}
