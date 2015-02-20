using UnityEngine;
using System.Collections;

public class ProjPro : MonoBehaviour {
	public float shoot_lr = 1;		// These two variables are used decide
	public float shoot_ud = 0;		// which direction the towers will shoot

	public float temp = 0;
	//public GameObject proj;
	public GameObject money;
	//public 

	// Use this for initialization
	void Start () {



		money = GameObject.Find ("money");
		if (money.GetComponent<MoneyHandle> ().mon - 15 < 0)
			Destroy (gameObject);
		else
			money.GetComponent<MoneyHandle>().mon -= 15;
		/*if (Input.GetKey (KeyCode.UpArrow)) {
			a = 1.0f;
			b = 0;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			a = -1.0f;	
			b =0;
		} else if ((Input.GetKey (KeyCode.RightArrow))) {
			a = 0;
			b = 0;
		}*/
	}
	
	// Update is called once per frame
	void Update () {
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

		transform.Translate(shoot_lr*8*Time.deltaTime, shoot_ud*8*Time.deltaTime, 0);
		//transform.position = Vector2.MoveTowards(transform.position, , 8 * Time.deltaTime);

		temp += Time.deltaTime;
		if (temp > 1.2) {
			Destroy(gameObject);
		}
		
		//Debug.Log (temp);
		//if (Input.GetKeyDown ("x"))
		//				break;
	}

}