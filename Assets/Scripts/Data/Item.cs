using UnityEngine;
using System.Collections;

[System.Serializable] //creates dropdown menu for each variable in class visible to Unity inspector
public class Item {
	/// basic variables for item declarations and types
	public string ItemName; //name of item
	public int ItemID; //Number value assignment per item for easy entry to inventory
	public string ItemDesc; //item description
	public Texture2D ItemIcon; //Item picture
	public int Damage; //how much damage the item does to the enemy
	public int ItemSpeed; //speed of the item movement
	public double SpeedDecrease; //if it hits an enemy, the enemy will slow down
	public ItemType itemtype; //determines the type of item
	public int itemCost;
	public enum ItemType{
		Weapon,
		Stat
	}

	public Item(string name, int id, string des, int damage, int speed, double speeddecrease, ItemType type, int cost)
	{
		ItemName = name;
		ItemID = id;
		ItemDesc = des;
		ItemIcon = Resources.Load<Texture2D> (name);
		Damage = damage;
		ItemSpeed = speed;
		SpeedDecrease = speeddecrease;
		itemtype = type;
		itemCost = cost;
	}
	public Item(){}
}
