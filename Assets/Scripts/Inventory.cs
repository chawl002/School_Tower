using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	public int SlotX, SlotY;
	public GUISkin skin;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item> ();
	private ItemDatabase database;
	private bool showInventory = true;
	// Use this for initialization
	void Start () 
	{
		//puts null box background with no items to show placement
		for (int i = 0; i < (SlotX * SlotY); i++) 
		{
			slots.Add(new Item());	
			inventory.Add (new Item());
		}
		//Gets items from gameobjects with a specific tag
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>(); 
		//puts a single item to the inventory slots 
		inventory[0] = database.items[0];
	}

	void Update()
	{
		//key bindings to i
		if(Input.GetButtonDown("Inventory"))
		{
			showInventory = !showInventory;
		}
	}

	void OnGUI() 
	{
		GUI.skin = skin;
		if(showInventory) 
		{
			DrawIventory();
		}
	}

	void DrawIventory()
	{
		int i = 0;
		for (int x = 0; x < SlotX; x++) 
		{
			for(int y = 0; y < SlotY; y++)
			{
				Rect slotRect = new Rect(x*55, y*55, 50, 50);
				GUI.Box (slotRect, "", skin.GetStyle("slot"));
				slots[i] = inventory[i];
				if(slots[i].ItemName != null)
				{
					GUI.DrawTexture(slotRect, slots[i].ItemIcon);
				}
				i++;
			}
		}
	}
}
