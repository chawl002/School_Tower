using UnityEngine;
using System.Collections;
using System.Collections.Generic; //gives access to more datatypes
public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add (new Item ("Bubble Gum", 0, "Slows down enemies when they step on this.", 0, 0, 10, Item.ItemType.Stat));
	}
}
