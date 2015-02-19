using UnityEngine;
using System.Collections;

public class Attack_toward_enemy : MonoBehaviour {
	
	public float temp = 0;
	public GameObject money;
	public GameObject[] enemies = null;
	
	// Use this for initialization
	void Start () {
		money = GameObject.Find ("money");
		if (money.GetComponent<MoneyHandle> ().mon - 15 < 0)
			Destroy (gameObject);
		else
			money.GetComponent<MoneyHandle>().mon -= 15;
	}
	
	// Update is called once per frame
	void Update () {
			GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
			if (enemies != null) {
						GameObject nearstEnemy = GetClosestEnemy (enemies);
						if (nearstEnemy != null) {
								Vector2 tmp = nearstEnemy.transform.position;
								transform.position = Vector2.MoveTowards (transform.position, tmp, 8 * Time.deltaTime);
				
								temp += Time.deltaTime;
								if (temp > 1.2) {
										Destroy (gameObject);
								}
						} else {
								Destroy (gameObject);
						}
				}
	}
	GameObject GetClosestEnemy(GameObject[] enemiesList)
	{
		GameObject tMin = null;
		float minDist = Mathf.Infinity;
		Vector2 currentPos = transform.position;
		
		foreach (GameObject t in enemiesList)
		{
			float dist = Vector2.Distance(t.transform.position, currentPos);
			if (dist < minDist)
			{
				tMin = t;
				minDist = dist;
			}
		}
		return tMin;
	}
}
