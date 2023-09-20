namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// A base class representing an item, providing common properties.
	/// </summary>
	internal class Item
	{
		#region Properties

		/// <summary>
		/// Gets or sets the ID of the item.
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name of the item.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the plural form of the item's name.
		/// </summary>
		public string NamePlural { get; set; }

		/// <summary>
		/// Gets or sets the description of the item.
		/// </summary>
		public string Description { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>Item</b> class.
		/// </summary>
		/// <param name="id">The ID of the item.</param>
		/// <param name="name">The name of the item.</param>
		/// <param name="namePlural">The plural form of the item's name.</param>
		/// <param name="description">The description of the item.</param>
		public Item(int id, string name, string namePlural, string description)
		{
			ID = id;
			Name = name;
			NamePlural = namePlural;
			Description = description;
		}
	}
}