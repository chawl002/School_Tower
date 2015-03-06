using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	public GameObject[] Levels;
	private int CurrentLevel = 1;
	private int LevelCounter = 0;

	void Start()
	{
		foreach (GameObject Level  in Levels) {
			//Only show levels by completion
			if (LevelCounter < CurrentLevel)
				Level.SetActive (true);
			else
				Level.SetActive (false);
			
			LevelCounter = LevelCounter + 1;
		}
	}

	public void GoBack(){
		Application.LoadLevel(0);
	}
	public void GameStart(){
		Application.LoadLevel(2);
	}
	public void goHighSchool(){
		Application.LoadLevel ("HighSchoolLevel");
	}
}
