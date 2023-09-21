namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents a player's inventory, which holds a list of all items the player currently has.
	/// </summary>
	internal class PlayerInventory
	{
		/// <summary>
		/// Gets or sets a list of all items present in the player's inventory.
		/// Each item is represented by a <b>PlayerInventoryItem</b> object which includes the item's details and the quantity the player has.
		/// </summary>
		public List<PlayerInventoryItem> PlayerInventoryItems { get; set; }

		/// <summary>
		/// Initializes a new instance of the <b>PlayerInventory</b> class.
		/// </summary>
		/// <param name="playerInventoryItems"></param>
		public PlayerInventory(List<PlayerInventoryItem> playerInventoryItems)
		{
			PlayerInventoryItems = playerInventoryItems;
		}
	}
}