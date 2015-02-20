using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	public int SPAWNTOWER = -1; //GLOBAL VARIABLE EQUALS TO ID NUMBER - SEE ITEM.CS FOR MORE INFO
	public bool click = false; //Did the user click on the item in inventory
	private Rect spot; //same as slotRect - saves the position of the clicked on item
	private int id = -1; //Id of the item currently clicked on - returns -1 if no item is clicked yet

	public int SlotX, SlotY; //Size of Inventory or Items you can own. Can change in Inspector
	public GUISkin skin;//The background of the Inventory slots

	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item> ();
	private ItemDatabase database;

	private bool showInventory = true; //Show all the items you own. Press i to hide
	private bool showToolTip; //Should we show item details?
	private string tooltip; //The item details output when the mouse hovers the item in inventory

	public GameObject mappy; //Used to get variables fro Spawn Paperboy

	// Use this for initialization
	void Start () 
	{
		mappy = GameObject.Find ("MapWithPaths");
		//puts null box background with no items to show placement
		for (int i = 0; i < (SlotX * SlotY); i++) 
		{
			slots.Add(new Item());	
			inventory.Add (new Item());
		}
		//Gets items from gameobjects with a specific tag
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>(); 
		//puts a single item to the inventory slots 
		//inventory[0] = database.items[0];
		AddItem (0);
		AddItem (1);
		AddItem (2);
	}

	//makes the inventory appear and disappear when the button i is pressed
	void Update()
	{
		if(Input.GetButtonDown("Inventory"))
		{
			showInventory = !showInventory;
		}
	}

	//draws the inventory if the showInventory bool is true.
	//Creates the GUI box used in the hoverable item info
	void OnGUI() 
	{
		tooltip = "";
		GUI.skin = skin;
		if(showInventory) 
		{
			DrawIventory();
		}
		if (showToolTip && showInventory)
		{
			GUI.Box (new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 200, 100), tooltip);
		}
	}

	//draws items in slots that exist in the slots/inventory lists, otherwise, draws an empty box for future items
	//Creates infomation box over items in inventory
	void DrawIventory()
	{
		int i = 0;
		for (int x = 0; x < SlotX; x++) 
		{
			for(int y = 0; y < SlotY; y++)
			{
				//Rectangle object for slots
				Rect slotRect = new Rect(x*55, y*55, 50, 50);
				GUI.Box (slotRect, "", skin.GetStyle("slot"));
				slots[i] = inventory[i];
				if(slots[i].ItemName != null)
				{
					if(!click)
					{
						GUI.DrawTexture(slotRect, slots[i].ItemIcon);
					}
					else{
						if(id != slots[i].ItemID)
						{
							GUI.DrawTexture(slotRect, slots[i].ItemIcon);
						}
						else{
						Texture2D highlight_texture = Resources.Load<Texture2D>(slots[id].ItemName+"_Highlight");
							GUI.DrawTextureWithTexCoords(spot, highlight_texture, new Rect(0f, 0f, 1f, 1f));}
						if(mappy.GetComponent<SpawnPaperboy> ().poop)
						{
							click = false;
							mappy.GetComponent<SpawnPaperboy> ().poop = false;
							SPAWNTOWER = -1;
							id = -1;
						}
					}

					//if the mouse is hovered over it, display information from createtooltip info
					if(slotRect.Contains (Event.current.mousePosition))
					{
						tooltip = CreateToolTip(slots[i]);
						showToolTip = true;
						if(Input.GetMouseButtonDown(0))
						{
							spot = slotRect;
							click = true;
							id = slots[i].ItemID;
							SPAWNTOWER = id;
						}
						/*if(!click){
							GUI.DrawTexture(slotRect, slots[i].ItemIcon);
							SPAWNTOWER = -1;
						}
						else{
							BUTTONFACE = highlight_texture;
							Click_Placement();
						}*/
					}

					
				}
				if(tooltip == "")
				{
					showToolTip = false;
				}
				i++;
			}
		}
	}

	//Creation of the info in the hoverable info box
	string CreateToolTip(Item item)
	{
		tooltip = item.ItemName + "\n\n" + item.ItemDesc + "\n\nCosts " + item.itemCost + " cents";
		return tooltip;
	}

	//Adds an item owned by the player to the inventory list.
	void AddItem(int id)
	{
		for (int i = 0; i < inventory.Count; i++) 
		{
			if(inventory[i].ItemName == null)
			{
				for(int j = 0; j < database.items.Count; j++)
				{
					if(database.items[j].ItemID == id)
					{
						inventory[i] = database.items[j];
					}
				}
				break;
			}

		}
	}
	//if the item exists in the player's inventory, return true. else return false
	bool FindItem(int id)
	{
		for (int i = 0; i < inventory.Count; i++) 
		{
			if (inventory[i].ItemID == id) 
			{
				return true;
			}
		}
		return false;
	}

	//removes the first item that is found with the same ID number. Does not move other items up to fill empty spot currently
	void RemoveItem(int id)
	{
		for (int i = 0; i < inventory.Count; i++) 
		{
			if (inventory[i].ItemID == id) 
			{
				inventory [i] = new Item ();
				break;
			}
		}
	}
}
