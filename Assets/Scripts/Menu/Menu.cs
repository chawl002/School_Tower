using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public void GoPlay(){
		Application.LoadLevel(1);
		}
	public void GoInstruct(){
		Application.LoadLevel (5);
	}
	public void Restart()
	{
		Application.LoadLevel (0);
	}
}