using UnityEngine;
using System.Collections;

public class Instructions	 : MonoBehaviour {
	
	public void GoInstruct1(){
		Application.LoadLevel ("Instructions");
	}
	public void GoInstruct2(){
		Application.LoadLevel ("Instructions2");
	}
	public void GoInstruct3(){
		Application.LoadLevel ("Instructions3");
	}
	public void GoInstruct4(){
		Application.LoadLevel ("Instructions4");
	}
	public void GoBack()
	{
		Application.LoadLevel ("OpeningTitle");
	}
}