using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private static int sceneLevel_lose;

	void Update()
	{
		sceneLevel_lose = EnemyMove.sceneLevel;
	}
	public void BackToMenu(){
		Application.LoadLevel(0);
	}
	public void GameSelect(){
		Application.LoadLevel(1);
	}
	public void Replay(){
		if (sceneLevel_lose == 0) {
						
			Application.LoadLevel ("ElementaryEntryLevel");
				
		} else if (sceneLevel_lose == 1) {
						
			Application.LoadLevel ("ElementaryLevelOne");
				
		} else if (sceneLevel_lose == 2) {
						
			Application.LoadLevel ("HighSchoolLevel");	
				
		} else if (sceneLevel_lose == 3) {
						
			Application.LoadLevel ("CollegeLevel");		
				
		} else {

			Application.LoadLevel ("GameSelection");
		}
	}
}
