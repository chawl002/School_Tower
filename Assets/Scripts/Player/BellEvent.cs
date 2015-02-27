using UnityEngine;
using System.Collections;

[System.Serializable]
public class BellEvent {

	public string Bellname;
	public int Bellmoney; //can find money or loose money
	public bool BellClearTowers; //clears all the towers from the screen
	public bool BellClearEnemy;

	public BellEvent(string EventName, int moneychange, bool clearscreen, bool clearenemy)
	{
		Bellname = EventName;
		Bellmoney = moneychange;
		BellClearTowers = clearscreen;
		BellClearEnemy = clearenemy;
	}
}
