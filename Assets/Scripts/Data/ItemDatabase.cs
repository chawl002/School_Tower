using UnityEngine;
using System.Collections;
using System.Collections.Generic; //gives access to more datatypes
public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add (new Item ("BubbleGum", 0, "Slows down enemies \n when they step on this.", 0, 0, 2.2, Item.ItemType.Stat, 25, "BubbleGumGirl"));
		items.Add (new Item ("Paperwad", 1, "Deals 1 damage \n point towards enemies", 1, 8, 0, Item.ItemType.Weapon, 15, "PaperwadBoy"));
		items.Add (new Item ("Baseball", 2, "Deals 1 damage \n point towards enemies. Can hit multiple enemies", 1, 8, 0, Item.ItemType.Weapon, 40, "BaseballBoy"));
		items.Add (new Item ("Dodgeball", 3, "Deals 1 damage \n point towards nearby enemies. Can hit multiple enemies", 1, 8, 0, Item.ItemType.Weapon, 35, "DodgeballGirl"));
		items.Add (new Item ("Paperplane", 4, "Deals 2 damage \n point towards nearby enemies.", 2, 7, 0, Item.ItemType.Weapon, 50, "PaperplaneGirl"));
		items.Add (new Item ("Candy", 5, "Slows an enemy down.", 0, 8, 0, Item.ItemType.Stat, 20, "Candykid"));
		items.Add (new Item ("Tack", 6, "Hits an enemy with 1 point of damage. Slows enemy a bit.", 0, 8, 0, Item.ItemType.Stat, 40, "Tackkid"));
		items.Add (new Item ("BigFs", 7, "Instantly defeats an enemy, but at a hefty cost, can you risk it? Unlocked by defeating a Professor F.", 100, 8, 0, Item.ItemType.Weapon, 100, "ProfessorF"));
	}
}
