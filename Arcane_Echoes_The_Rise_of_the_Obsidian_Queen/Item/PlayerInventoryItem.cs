namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents an item in the player's inventory, including its details and the quantity that the player has.
	/// </summary>
	internal class PlayerInventoryItem
	{
		#region Properties

		/// <summary>
		/// Gets or sets the details of the item.
		/// </summary>
		public Item Details { get; set; }

		/// <summary>
		/// Gets or sets the quantity of the item that the player has in their inventory.
		/// </summary>
		public int Quantity { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>PlayerInventoryItem</b> class.
		/// </summary>
		/// <param name="details">The details of the item.</param>
		/// <param name="quantity">The quantity of the item that the player has in their inventory.</param>
		public PlayerInventoryItem(Item details, int quantity)
		{
			Details = details;
			Quantity = quantity;
		}
	}
}