using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float shoot_lr = 1;		// These two variables are used decide
	public float shoot_ud = 0;		// which direction the towers will shoot

	public float temp = 0;
	public GameObject our;
	public GameObject proj;
	public GameObject projClone;


	// Use this for initialization
	void Start () {
		if(Input.GetKey ("up") || Input.GetKey("w") ){				// if the up arrow key or w is pressed then
			shoot_lr = 0f;											// the next tower created will shoot up
			shoot_ud = 1f;
		}
		else if(Input.GetKey ("down") || Input.GetKey("s") ){		// if the down arrow key or s is pressed then
			shoot_lr = 0f;											// the next tower created will shoot down
			shoot_ud = -1f;
		}
		else if(Input.GetKey ("left") || Input.GetKey("a") ){		// if the left arrow key or a is pressed then
			shoot_lr = -1f;											// the next tower created will shoot left
			shoot_ud = 0f;
		}
		else if(Input.GetKey ("right") || Input.GetKey("d") ){		// if the right arrow key or d is pressed then
			shoot_lr = 1f;											// the next tower created will shoot right
			shoot_ud = 0f;
		}

	}
	
	// Update is called once per frame
	void Update () {

		temp += Time.deltaTime;
		if (temp >= 2) {
			//do projectile
			temp = 0;
			Vector3 pos = transform.position;


			projClone = Instantiate(proj, pos, transform.rotation) as GameObject; //Instantiate(tragedy);
			projClone.transform.parent = gameObject.transform;
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
