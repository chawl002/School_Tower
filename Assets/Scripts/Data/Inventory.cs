using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//SOME OF THIS CODE IS FROM AWFUL MEDIA YOUTUBE TUTORIALS

public class Inventory : MonoBehaviour {
	public int SPAWNTOWER = -1; //GLOBAL VARIABLE EQUALS TO ID NUMBER - SEE ITEM.CS FOR MORE INFO
	public bool click = false; //Did the user click on the item in inventory
	private Rect spot; //same as slotRect - saves the position of the clicked on item

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
		//puts null box background with no items to show placement and how much you can own
		for (int i = 0; i < (SlotX * SlotY); i++) 
		{
			slots.Add(new Item());	
			//add blank objects
			inventory.Add (new Item());
		}
		//Gets items from gameobjects with a specific tag
		database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>(); 

		//Add in current items owned here:
		AddItem (0);
		AddItem (1);
		AddItem (2);
	}

	//makes the inventory appear and disappear when the button i is pressed
	void Update()
	{
		//if the user presses i, inventory hides
		if(Input.GetButtonDown("Inventory"))
		{
			showInventory = !showInventory;
		}
	}

	//draws the inventory if the showInventory bool is true.
	//Creates the GUI box used in the hoverable item info
	void OnGUI() 
	{
		//OUTPUT INVENTORY OPTIONS 
		tooltip = "";//string with item details is null when there is no items
		GUI.skin = skin;
		if(showInventory) 
		{
			//draw everything
			DrawIventory();
		}
		if (showToolTip && showInventory)
		{
			GUI.Box (new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 200, 100), tooltip);
		}
	}

	//draws items in slots that exist in the slots/inventory lists, otherwise, draws an empty box for future items
	//Creates infomation box over items in inventory
	//Determines if an item is clicked or not and returns global variables for SpawnPaperboy.cs to use for tower instanciation
	void DrawIventory()
	{
		int i = 0;
		for (int x = 0; x < SlotX; x++) 
		{
			for(int y = 0; y < SlotY; y++)
			{
				//Rectangle object for slots
				Rect slotRect = new Rect(x*55, y*55, 50, 50);
				GUI.Box (slotRect, "", skin.GetStyle("slot")); //Color slots with skin
				slots[i] = inventory[i];//have a copy of inventory

				if(slots[i].ItemName != null) //If there is an item
				{
					if(!click)
					{
						//Draw the item normally
						GUI.DrawTexture(slotRect, slots[i].ItemIcon);
					}
					else //If the user clicked on the item, highlight it blue
					{
						if(SPAWNTOWER != slots[i].ItemID)
						{
							//make sure other items in inventory do not turn blue - only the clicked object should
							GUI.DrawTexture(slotRect, slots[i].ItemIcon);
						}
						else
						{
							//Highlight blue
							Texture2D highlight_texture = Resources.Load<Texture2D>(slots[SPAWNTOWER].ItemName+"_Highlight");
							GUI.DrawTextureWithTexCoords(spot, highlight_texture, new Rect(0f, 0f, 1f, 1f));
						}
						//Poop is a global variable from SpawnPaperBoy that determines if the tower has been placed
						if(mappy.GetComponent<SpawnPaperboy> ().poop)
						{
							//If the tower has been placed, update global variables from the first item click
							click = false;
							mappy.GetComponent<SpawnPaperboy> ().poop = false;
							SPAWNTOWER = -1;
						}
					}

					//if the mouse is hovered over it, display information from createtooltip info
					if(slotRect.Contains (Event.current.mousePosition))
					{
						//output item information
						tooltip = CreateToolTip(slots[i]);
						showToolTip = true;

						//If there is a click, change global variables for SpawnPaperBoy to access
						if(Input.GetMouseButtonDown(0))
						{
							spot = slotRect; //position of item in inventory
							click = true; 
							SPAWNTOWER = slots[i].ItemID;
						}
					}
				}
				//reset item information
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
