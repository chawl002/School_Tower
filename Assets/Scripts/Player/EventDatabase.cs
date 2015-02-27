using UnityEngine;
using System.Collections;
using System.Collections.Generic; //gives access to more datatypes such as List

public class EventDatabase : MonoBehaviour {
	public List<BellEvent> event_list = new List<BellEvent>();

	void Start()
	{
		event_list.Add (new BellEvent("Loose Money", -1, false, false));
		event_list.Add (new BellEvent("Gain Money", 1, false, false));
		event_list.Add (new BellEvent("Class is starting - your troop have left", 0, true, false));
		event_list.Add (new BellEvent("Enemy troops have left", 0, false, true));

	}
}