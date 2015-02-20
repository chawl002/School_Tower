using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float temp = 0;
	public GameObject our;
	public GameObject proj;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		temp += Time.deltaTime;
		if (temp >= 2) {
			//do projectile
			temp = 0;
			Vector3 pos = transform.position;


			/*GameObject shot = */GameObject.Instantiate(proj, pos, transform.rotation); //Instantiate(tragedy);
			//shot.GetComponent<IndexInList>().INDEX = 
			//DestroyObject(this);
			//if(transform.root.gameObject){
			//	Destroy(transform.root.gameObject);
			//}
		}

		//Debug.Log (temp);
		//if (Input.GetKeyDown ("x"))
		//				break;
	}
	
}
