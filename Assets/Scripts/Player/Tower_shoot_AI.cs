using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tower_shoot_AI : MonoBehaviour {

	public GameObject enemy;
	public float Range;
	public float bulletSpeed;
	public GameObject bullet;
	private int flag ;
	public int towerCooldown;
	private GameObject[] enemies = null;
	private int cooldownCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		enemies = GameObject.FindGameObjectsWithTag("enemy");

		GameObject nearstEnemy = GetClosestEnemy (enemies);
		//Vector2 nearest = nearstEnemy.transform.position;

		//if enemy is in the range of tower and the tower able to shoot
		if (Vector2.Distance (transform.position, nearstEnemy.transform.position) <= Range && flag == 0) {

			//spawn a bullet
			//Vector2 spawnPosition = this.transform.position;

			//Instantiate (bullet,spawnPosition,Quaternion.identity);
			GameObject.Instantiate(bullet, this.transform.position, transform.rotation);

			//get enemy position
			Vector2 tmp = nearstEnemy.transform.position;
			//float step = bulletSpeed *Time.deltaTime;

			//bullet shoot to the enemy
			while (true){
				bullet.transform.position = Vector2.MoveTowards(bullet.transform.position,tmp,bulletSpeed *Time.deltaTime);
				if (bullet.transform.position.x == tmp.x && bullet.transform.position.y == tmp.y)
				{
					//Destroy (nearstEnemy);	
					Destroy (bullet);
					break;
				}
			}
			flag = 1;
			cooldownCounter = 0;
		}
		if (towerCooldown != 0) {
			towerCooldown--;	
			cooldownCounter++;
		} else 
		{
			flag = 0;
			towerCooldown = cooldownCounter;
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
