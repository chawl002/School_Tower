using UnityEngine;
using System.Collections;

public class GumPower : MonoBehaviour {

	public float temp = 0;
	public Vector2 dirk;

	float shot_lr, shot_ud;

	//public GameObject proj;
	public GameObject money;
	
	// Use this for initialization
	void Start () {
		//transform.Translate (0f, -1f, 0f);
		money = GameObject.Find ("money");
		if (money.GetComponent<MoneyHandle> ().mon - 25 < 0)
						Destroy (gameObject);
		else
			money.GetComponent<MoneyHandle>().mon -= 25;

		shot_lr = GetComponentInParent<Projectile>().shoot_lr;
		shot_ud = GetComponentInParent<Projectile>().shoot_ud;



	}

	// Update is called once per frame
	void Update () {
		if(temp < 0.5)

				transform.Translate(0.05f*shot_lr, 0.05f*shot_ud, 0);

		temp += Time.deltaTime;
		if (temp >= 3) {
			Destroy(gameObject);
		}
	}

	/*void OnCollisionEnter2D(Collision2D coll)
	{
		//MAKE HIM CONTINUE TO THROW GUM
		GetComponentInParent<ThrowGum> ().throwg = true;
			//Physics2D.IgnoreCollision (coll.gameObject.collider2D, collider2D);
	}*/
}
