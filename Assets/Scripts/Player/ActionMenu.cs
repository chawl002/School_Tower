using UnityEngine;
using System.Collections;

public class ActionMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnClick(string actionName)
	{
		switch (actionName)
		{
		case "Left":
			DoLeft();
			break;
		case "Right":
			//DoRight();
			break;
		case "Up":
			//DoUp();
			break;
		case "Down":
		//	DoDown();s 
			break;
		}
	}
	
	private void DoLeft()
	{


	}

}
