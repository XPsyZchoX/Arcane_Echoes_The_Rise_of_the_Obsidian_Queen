namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents a location within the game. Each location has a unique ID, name, and description.<br/>
	/// A location can also require an item to be entered, and it can have a quest available.<br/>
	/// Each location also contains references to adjacent locations in each cardinal direction (North, East, South, West).
	/// </summary>
	internal class Location
	{
		#region Properties

		/// <summary>
		/// Gets or sets the ID of the location.
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name of the location.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description of the location.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the item that is required for the player to enter this location.<br/>
		/// This property can be null, indicating that no item is required to enter.
		/// </summary>
		public Item? RequiredItemToEnter { get; set; }

		/// <summary>
		/// Gets or sets the available quest at this location.
		/// This property can be null, indicating that no quest is available here.
		/// </summary>
		public Quest? QuestAvailableHere { get; set; }

		/// <summary>
		/// Gets or sets the location positioned to the North of this location.
		/// </summary>
		public Location? LocationToNorth { get; set; }

		/// <summary>
		/// Gets or sets the location positioned to the East of this location.
		/// </summary>
		public Location? LocationToEast { get; set; }

		/// <summary>
		/// Gets or sets the location positioned to the South of this location.
		/// </summary>
		public Location? LocationToSouth { get; set; }

		/// <summary>
		/// Gets or sets the location positioned to the West of this location.
		/// </summary>
		public Location? LocationToWest { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>Location</b> class.
		/// </summary>
		/// <param name="id">The ID of the location.</param>
		/// <param name="name">The name of the location.</param>
		/// <param name="description">The description of the location.</param>
		/// <param name="requiredItemToEnter">The item that is required for the player to enter this location. The default is null</param>
		/// <param name="questAvailableHere">The available quest at this location. The default is null</param>
		public Location(int id, string name, string description, Item? requiredItemToEnter = null, Quest? questAvailableHere = null)
		{
			ID = id;
			Name = name;
			Description = description;
			RequiredItemToEnter = requiredItemToEnter;
			QuestAvailableHere = questAvailableHere;
		}
	}
}