namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents a quest within the game world.<br/>
	/// It includes properties for identifying the quest (ID, Name, Description),
	/// its rewards (Gold, Experience Points, Reward Item),<br/>
	/// its completion status (IsCompleted), and
	/// items required for its completion (CompletionItems).
	/// </summary>
	internal class Quest
	{
		#region Properties

		/// <summary>
		/// Gets or sets the ID of the quest.
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// Gets or sets the name of the quest.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description of the quest.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the amount of gold rewarded to the player on completion of the quest.
		/// </summary>
		public int RewardGold { get; set; }

		/// <summary>
		/// Gets or sets the amount of experience points rewarded to the player on completion of the quest.
		/// </summary>
		public int RewardExperiencePoints { get; set; }

		/// <summary>
		/// Gets or sets if the player has completed the quest.
		/// </summary>
		public bool IsCompleted { get; set; }

		/// <summary>
		/// Gets or sets the item rewarded to the player on completion of the quest.
		/// This property can be null, indicating that no item is rewarded to the player.
		/// </summary>
		public Item? RewardItem { get; set; }

		/// <summary>
		/// Gets or sets a list of items that are required for the completion of the quest.
		/// This property can be null, indicating that no items are required for the completion of the quest.
		/// </summary>
		public List<QuestCompletionItem>? CompletionItems { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>Quest</b> class.
		/// </summary>
		/// <param name="id">The ID of the quest.</param>
		/// <param name="name">The name of the quest.</param>
		/// <param name="description">The description of the quest.</param>
		/// <param name="rewardGold">The amount of gold rewarded to the player on completion of the quest.</param>
		/// <param name="rewardExperiencePoints">The amount of experience points rewarded to the player on completion of the quest.</param>
		/// <param name="isCompleted">Decides if the player has completed the quest. The default is false.</param>
		public Quest(int id, string name, string description, int rewardGold, int rewardExperiencePoints, bool isCompleted = false)
		{
			ID = id;
			Name = name;
			Description = description;
			RewardGold = rewardGold;
			RewardExperiencePoints = rewardExperiencePoints;
			IsCompleted = isCompleted;
		}
	}
}