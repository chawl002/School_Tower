﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public void GoPlay(){
		Application.LoadLevel("GameSelection");
		}
	public void GoInstruct(){
		Application.LoadLevel ("Instructions");
	}
	public void GoCredit(){
		Application.LoadLevel ("Credits");
	}
	public void Restart()
	{
		Application.LoadLevel ("OpeningTitle");
	}
}