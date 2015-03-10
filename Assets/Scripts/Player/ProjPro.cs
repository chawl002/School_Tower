using UnityEngine;
using System.Collections;

public class ProjPro : MonoBehaviour {
	public float lr = 0;		// These two variables are used decide
	public float ud = 0;		// which direction the towers will shoot

	public float temp = 0;
	//public GameObject proj;
	public GameObject money;
	public GameObject Inventor;
	public GameObject Invent;
	public int ItemIndexInInventory = -1;
	public int damage = 0;


	// Use this for initialization
	void Start () {

		Invent = GameObject.Find ("Inventory");

		ItemIndexInInventory = GetComponentInParent<AssignWeap> ().ItemIndexInInventory;//GetComponent<IndexInList> ().INDEX;//Invent.GetComponent<Inventory> ().SPAWNTOWER;

		Inventor = GameObject.Find ("Item Database");

		damage = Inventor.GetComponent<ItemDatabase>().items[ItemIndexInInventory].Damage;

		GetComponent<damage> ().damag = damage;

		//Debug.Log ("My damage is " + damage);

		money = GameObject.Find ("money");


		//Debug.Log (Inventor.GetComponent<ItemDatabase> ().items [0].ItemName);//GetComponent<IndexInList> ().INDEX].itemCost);

		if (money.GetComponent<MoneyHandle> ().mon - Inventor.GetComponent<ItemDatabase> ().items [ItemIndexInInventory].itemCost < 0) {
						money.GetComponent<MoneyHandle> ().mon = 0;
						Destroy (gameObject);
				}

		else
			money.GetComponent<MoneyHandle>().mon -= Inventor.GetComponent<ItemDatabase>().items[ItemIndexInInventory].itemCost;
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

		lr = GetComponentInParent<Projectile>().shoot_lr;
		ud = GetComponentInParent<Projectile>().shoot_ud;

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(lr*8*Time.deltaTime, ud*8*Time.deltaTime, 0);
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