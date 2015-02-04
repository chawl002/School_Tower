using UnityEngine;
using System.Collections;

public class ThrowGum : MonoBehaviour {

	public float temp = 0;
	public GameObject gum;

	// Use this for initialization
	void Start () {
		//GameObject.Instantiate(gum, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {


		temp += Time.deltaTime;
		if (temp >= 3) {
			//do projectile
			temp = 0;
			Vector3 pos = transform.position;
			
			
			GameObject.Instantiate(gum, pos, transform.rotation); //Instantiate(tragedy);
			//DestroyObject(this);
			//if(transform.root.gameObject){
			//	Destroy(transform.root.gameObject);
			//}
		}

	
	}
}
