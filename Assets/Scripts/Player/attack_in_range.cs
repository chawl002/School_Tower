using UnityEngine;
using System.Collections;

public class attack_in_range : MonoBehaviour {

	public float temp = 0;
	public GameObject proj;
	public float range;
	public GameObject[] enemies = null;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		enemies = GameObject.FindGameObjectsWithTag("enemy");
		GameObject nearstEnemy = GetClosestEnemy (enemies);

		temp += Time.deltaTime;
		if (temp >= 2 && Vector2.Distance (transform.position, nearstEnemy.transform.position) <= range && enemies != null) {
			//do projectile
			temp = 0;
			Vector3 pos = transform.position;
			
			GameObject.Instantiate(proj, pos, transform.rotation);
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
