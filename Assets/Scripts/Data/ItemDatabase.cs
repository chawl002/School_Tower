using UnityEngine;
using System.Collections;
using System.Collections.Generic; //gives access to more datatypes
public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add (new Item ("BubbleGum", 0, "Slows down enemies \n when they step on this.", 0, 0, 2.2, Item.ItemType.Stat, 25));
		items.Add (new Item ("Paperwad", 1, "Deals 1 damage \n point towards enemies", 1, 8, 0, Item.ItemType.Weapon, 15));
		items.Add (new Item ("baseball", 2, "Deals 1 damage \n point towards enemies. Can hit multiple enemies", 1, 8, 0, Item.ItemType.Weapon, 40));
		items.Add (new Item ("dodgeballer", 3, "Deals 1 damage \n point towards nearby enemies. Can hit multiple enemies", 1, 8, 0, Item.ItemType.Weapon, 35));
		items.Add (new Item ("paperplane", 4, "Deals 2 damage \n point towards nearby enemies.", 2, 7, 0, Item.ItemType.Weapon, 50));
		items.Add (new Item ("candy", 5, "Slows an enemy down.", 0, 8, 0, Item.ItemType.Stat, 20));
	}
}
