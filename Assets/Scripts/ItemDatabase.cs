using UnityEngine;
using System.Collections;
using System.Collections.Generic; //gives access to more datatypes
public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add (new Item ("BubbleGum", 0, "Slows down enemies when they step on this.", 0, 0, 2.2, Item.ItemType.Stat));
		items.Add (new Item ("Paperwad", 1, "Deals 1 damage point towards enemies", 1, 8, 0, Item.ItemType.Weapon));
	}
}
