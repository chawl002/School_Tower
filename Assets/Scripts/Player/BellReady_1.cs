﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BellReady_1 : MonoBehaviour 
{
	private Color ourColor;
	private Color color = new Color();
	private float roti = 0.075f;
	private Vector3 Rot = new Vector3();
	private bool rotfin = false;
	private int rotdir = 1;
	public bool mover = false;
	public bool clicked = false;
	public int rate = 2;
	float temp = 0;
	float msg_tmp = 5.0f;
	bool fadeAudio = false;
	public GameObject money;
	public string eventMessage;
	public float y_pos = 250;
	
	//used to instanciate random events when bell is clicked
	public int num_events = 4; //max size of EventDatabase list (calling item from 
	private int rand_event; //event value number in list
	private bool bell_event = true; //controls number of times rand function is called
//	public GameObject found_object;
	
	// Use this for initialization
	void Start () {
		
		Rot.x = 0;
		Rot.y = 0;
		Rot.z = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		ourColor = renderer.material.GetColor("_Color");
		
		if (clicked) 
		{
			//play the bell ring noise
			if(!audio.isPlaying)
			{audio.Play();}
			
			//pick a random event to execute once
			if(bell_event)
			{	
				rand_event = Random.Range(0, 100);
				//Debug.Log(rand_event);
				bell_event = false;
				money = GameObject.Find ("money");
				if(rand_event < 25) //Player finds 5 dollar bill from bell event
				{
					//Debug.Log("Player gains 500 money from bell");
					
					if(Application.loadedLevelName == "ElementryEntryLevel"){
						money.GetComponent<MoneyHandle>().mon += 200;
						eventMessage = "Player finds 2\n dollar bill";
					}
					else if(Application.loadedLevelName == "ElementaryLevelOne"){
						money.GetComponent<MoneyHandle>().mon += 500;
						eventMessage = "Player finds 5\n dollar bill";
					}
					else if(Application.loadedLevelName == "HighSchoolLevel"){
						money.GetComponent<MoneyHandle>().mon += 1000;
						eventMessage = "Player finds 10\n dollar bill";
					}
					else if(Application.loadedLevelName == "CollegeLevel"){
						money.GetComponent<MoneyHandle>().mon += 2000;
						eventMessage = "Player finds 20\n dollar bill";
					}
				}
				else if(rand_event >= 25 && rand_event < 50) //Player finds 10 dollar bill from bell event
				{
					Debug.Log("Random destroy");
					DestroyGameObjectsWithTag("enemy", true);
					DestroyGameObjectsWithTag("tower", true);
					eventMessage = "Some enemies and troops \n went to class";
				}
				else if(rand_event >= 50 && rand_event < 75){//Player's towers are destroyed
					Debug.Log("Player towers destroyed");
					DestroyGameObjectsWithTag("tower", false);
					//found_object = GameObject.FindWithTag ("tower", false);
					eventMessage = "Player's troops \nleft for class";
				}
				else if(rand_event >= 75){//Enemies are destroyed
					Debug.Log("Enemies are \ndestroyed");
					DestroyGameObjectsWithTag("enemy", false);
					eventMessage = "Enemies left for class";
				}
				msg_tmp = 0f; //displays message begins
			}
			
			//updates time variable
			temp+= Time.deltaTime;
			//if the noise has played for 2 seconds, shut down.
			if(temp >= 2)
			{
				clicked = false;
				GetComponent<BellFadeIn>().ready = false;
				
				color.r = ourColor.r;
				color.g = ourColor.g;
				color.b = ourColor.b;
				color.a = 0.6f;
				renderer.material.SetColor ("_Color", color);
				
				if (transform.rotation.z != 0)
				{transform.rotation = Quaternion.identity;}
				
				temp = 0;
				bell_event = true;
				fadeAudio = true;
				
			}
		}
		
		if (fadeAudio) 
		{
			audio.volume -= 0.1f;
			if(audio.volume <=0)
			{
				audio.Stop();
				audio.volume = 1.0f;
				fadeAudio = false;
			}
			
		}
		
		if (ourColor.a == 1) 
		{
			if (rotfin == true) {
				
				roti = -1 * roti;
				rotdir = -1 * rotdir;
				rotfin = false;
			}
			
			if(clicked == true)
			{
				rate = 8;
			}
			
			transform.Rotate (Rot * rotdir*rate);
			rate = 1;
			
			if (GetComponent<Transform> ().rotation.z * GetComponent<Transform> ().rotation.z >= roti * roti)
			{rotfin = true;}
			
			mover = false;
		}
	}
	
	void OnGUI(){
		if(msg_tmp < 6.0f){ 
			GUI.Box (new Rect(Input.mousePosition.x,y_pos-Input.mousePosition.y, 200, 50), eventMessage);
			msg_tmp += Time.deltaTime;
		}
	}
	
	
	//check to see if user has clicked the bell
	void OnMouseOver()
	{
		if (ourColor.a == 1) 
		{
			mover = true;
			rate++;
		}
		if (Input.GetMouseButtonDown (0) && ourColor.a == 1) 
		{
			clicked = true;
		} 
	}
	
	public static void DestroyGameObjectsWithTag(string tag, bool random)
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
		if(random == false){
			foreach (GameObject target in gameObjects) {
				GameObject.Destroy(target);
			}
		}
		else{
			foreach (GameObject target in gameObjects) {
					if(Random.Range(0,100) < 65){
						GameObject.Destroy(target);
					}
			}
		}
	}
}
