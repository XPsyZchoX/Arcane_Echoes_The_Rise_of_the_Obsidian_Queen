namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents an item that is required to complete a quest, including its details and required quantity.
	/// </summary>
	internal class QuestCompletionItem
	{
		#region Properties

		/// <summary>
		/// Gets or sets the details of the item.
		/// </summary>
		public Item Details { get; set; }

		/// <summary>
		/// Gets or sets the quantity of the item that is required for the completion of the quest.
		/// </summary>
		public int Quantity { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>QuestCompletionItem</b> class.
		/// </summary>
		/// <param name="details">The details of the item.</param>
		/// <param name="quantity">The quantity of the item that is required for the completion of the quest.</param>
		public QuestCompletionItem(Item details, int quantity)
		{
			Details = details;
			Quantity = quantity;
		}
	}
}