﻿using UnityEngine;
using System.Collections;

public class HallMon : MonoBehaviour {
	
	public bool hasVision = false;
	
	public GameObject vis;
	public GameObject visClone;
	
	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		
		visClone = Instantiate(vis, pos, transform.rotation) as GameObject; //Instantiate(tragedy);
		visClone.transform.parent = gameObject.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
