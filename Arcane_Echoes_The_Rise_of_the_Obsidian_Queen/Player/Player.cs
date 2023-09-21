namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	internal class Player
	{
		#region Properties

		/// <summary>
		/// Gets or sets the name of the player.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the player's current hit points.
		/// </summary>
		public int CurrentHitPoints { get; set; }

		/// <summary>
		/// Gets or sets the player's maximum hit points.
		/// </summary>
		public int MaximumHitPoints { get; set; }

		/// <summary>
		/// Gets or sets the player's current amount of gold.
		/// </summary>
		public int Gold { get; set; }

		/// <summary>
		/// Gets or sets the player's current experience points.
		/// </summary>
		public int ExperiencePoints { get; set; }

		/// <summary>
		/// Gets or sets the player's current level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Gets or sets the player's current location in the game world.
		/// </summary>
		public Location? CurrentLocation { get; set; }

		/// <summary>
		/// Gets or sets the list of quests that the player currently has in their quest log.
		/// </summary>
		public List<Quest>? QuestLog { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>Player</b> class.
		/// </summary>
		/// <param name="name">The name of the player.</param>
		/// <param name="currentHitPoints">The player's current hit points.</param>
		/// <param name="maximumHitPoints">The player's maximum hit points.</param>
		/// <param name="gold">The player's current amount of gold.</param>
		/// <param name="experiencePoints">The player's current experience points.</param>
		/// <param name="level">The player's current level.</param>
		public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level)
		{
			Name = name;
			CurrentHitPoints = currentHitPoints;
			MaximumHitPoints = maximumHitPoints;
			Gold = gold;
			ExperiencePoints = experiencePoints;
			Level = level;
		}
	}
}