using UnityEngine;
using System.Collections;

public class EndReached : MonoBehaviour {

	void OnTriggerEvent2D(Collider2D co){
		if (co.name == "Sphere")
			Destroy (co.gameObject);
	}
}
