using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	public GameObject[] Levels;
	private int CurrentLevel = 1;
	private int LevelCounter = 0;
	
	//public EnemyMove enemyMove;
	private static int sceneLevel_win;

	void Update()
	{
		sceneLevel_win = MoneyHandle.curLevel_win;
	}
	/*void Start()
	{
		foreach (GameObject Level  in Levels) {
			//Only show levels by completion
			if (LevelCounter < CurrentLevel)
				Level.SetActive (true);
			else
				Level.SetActive (false);
			
			LevelCounter = LevelCounter + 1;
		}
	}*/

	public void GoBack(){

		Application.LoadLevel("OpeningTitle");
	}
	public void GoElementaryLevel(){

		Application.LoadLevel("ElementaryLevelOne");
	}
	public void goHighSchool(){

		Application.LoadLevel ("HighSchoolLevel");
	}
	public void GoEnrtyLevel(){

		Application.LoadLevel ("ElementaryEntryLevel");
	}
	public void GoCollegeLevel(){

		Application.LoadLevel ("CollegeLevel");
	}
	public void GoNextLevel(){
		if (sceneLevel_win == 0) {

			Application.LoadLevel ("ElementaryLevelOne");

		} else if (sceneLevel_win == 1) {

			Application.LoadLevel ("HighSchoolLevel");	

		} else if (sceneLevel_win == 2) {

			Application.LoadLevel ("CollegeLevel");	

		} else if (sceneLevel_win == 3) {

			Application.LoadLevel ("GameSelection");

		} else {

			Application.LoadLevel ("GameSelection");
		}
	}
}
