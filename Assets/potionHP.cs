using UnityEngine;
using System.Collections;

public class potionHP : MonoBehaviour {

	float tempi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempi += Time.deltaTime;
		if (tempi >= 3)
			Destroy (gameObject);

	
	}
}
