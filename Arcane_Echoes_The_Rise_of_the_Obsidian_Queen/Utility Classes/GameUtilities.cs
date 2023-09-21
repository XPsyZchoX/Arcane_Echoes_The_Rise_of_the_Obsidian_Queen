namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// A utility class that serves as a hub for game-related lists, constants, and methods organized in a centralized location.
	/// </summary>
	internal static class GameUtilities
	{
		#region Properties and Constants

		#region Lists

		/// <summary>
		/// A list holding all items that can be interacted with throughout the game.
		/// </summary>
		private static readonly List<Item> AllItems = new();

		/// <summary>
		/// A list holding all locations that can be interacted with throughout the game.
		/// </summary>
		private static readonly List<Location> AllLocations = new();

		/// <summary>
		/// A list holding all quests that can be interacted with throughout the game.
		/// </summary>
		private static readonly List<Quest> AllQuests = new();

		#endregion Lists

		#region ItemIDs

		/// <summary>
		/// A constant id for the item Iron Ore.
		/// </summary>
		public const int ItemIDIronOre = 1;

		/// <summary>
		/// A constant id for the item Sturdy Wood.
		/// </summary>
		public const int ItemIDSturdyWood = 2;

		#endregion ItemIDs

		#region LocationIDs

		/// <summary>
		/// A constant id for the location Eldrin's Forge.
		/// </summary>
		public const int LocationIDEldrinsForge = 1;

		/// <summary>
		/// A constant id for the location Forest.
		/// </summary>
		public const int LocationIDForest = 2;

		#endregion LocationIDs

		#region QuestIDs

		/// <summary>
		/// A constant id for the quest The Blacksmith's Need.
		/// </summary>
		public const int QuestIDTheBlacksmithsNeed = 1;

		#endregion QuestIDs

		#endregion Properties and Constants

		/// <summary>
		/// Initializes a new instance of the <b>GameUtilities</b> class.
		/// </summary>
		static GameUtilities()
		{
			PopulateListAllItems();
			PopulateListAllLocations();
			PopulateListAllQuests();
		}

		#region Methods PopulateList

		/// <summary>
		/// Populates the list AllItems.
		/// </summary>
		private static void PopulateListAllItems()
		{
			// Create each item and add them to the list
			AllItems.Add(new Item(ItemIDIronOre, "Iron Ore", "Iron Ore", "Iron ore is a valuable, heavy rock with a metallic essence that is pivotal in crafting a variety of useful tools and weapons in the blacksmith's forge."));
			AllItems.Add(new Item(ItemIDSturdyWood, "Sturdy Wood", "Sturdy Wood", "Sturdy Wood, characterized by its resilience and strength, is a vital resource in various crafting endeavors, from blacksmithing to architecture."));
		}

		/// <summary>
		/// Populates the list AllLocations.
		/// </summary>
		private static void PopulateListAllLocations()
		{
			// Create each location
			Location eldrinsForge = new(LocationIDEldrinsForge, "TODO", "TODO");
			Location forest = new(LocationIDForest, "TODO", "TODO");

			// Link the locations together
			eldrinsForge.LocationToNorth = forest;

			// Add each location to the list
			AllLocations.Add(eldrinsForge);
		}

		/// <summary>
		/// Populates the list AllQuests.
		/// </summary>
		private static void PopulateListAllQuests()
		{
			// Create each quest
			Quest theBlacksmithsNeed = new(QuestIDTheBlacksmithsNeed, "TODO", "TODO", 0, 0);
			theBlacksmithsNeed.CompletionItems.Add(new QuestCompletionItem(GetItemByID(ItemIDIronOre), 3));

			// Add each quest to the list
			AllQuests.Add(theBlacksmithsNeed);
		}

		#endregion Methods PopulateList

		#region Methods GetByID

		/// <summary>
		/// Retrieves the <b>Item</b> object corresponding to the specified ID.
		/// </summary>
		/// <param name="id">The ID of the item to be retrieved.</param>
		/// <returns>The <b>Item</b> object with the given ID, or null if no such item exists.</returns>
		public static Item? GetItemByID(int id)
		{
			foreach (Item item in AllItems)
				if (item.ID == id)
					return item;

			return null;
		}

		/// <summary>
		/// Retrieves the <b>Location</b> object corresponding to the specified ID.
		/// </summary>
		/// <param name="id">The ID of the location to be retrieved.</param>
		/// <returns>The <b>Location</b> object with the given ID, or null if no such item exists.</returns>
		public static Location? GetLocationByID(int id)
		{
			foreach (Location location in AllLocations)
				if (location.ID == id)
					return location;

			return null;
		}

		/// <summary>
		/// Retrieves the <b>Quest</b> object corresponding to the specified ID.
		/// </summary>
		/// <param name="id">The ID of the quest to be retrieved.</param>
		/// <returns>The <b>Quest</b> object with the given ID, or null if no such item exists.</returns>
		public static Quest? GetQuestByID(int id)
		{
			foreach (Quest quest in AllQuests)
				if (quest.ID == id)
					return quest;

			return null;
		}

		#endregion Methods GetByID
	}
}