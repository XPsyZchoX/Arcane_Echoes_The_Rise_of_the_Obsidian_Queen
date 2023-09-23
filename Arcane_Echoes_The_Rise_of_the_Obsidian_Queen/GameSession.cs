using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.BasicUtilities;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// Represents an active session of the game.
	/// </summary>
	internal class GameSession
	{
		#region Properties

		/// <summary>
		/// Gets or sets the information of the player in the current game session.
		/// </summary>
		public Player CurrentPlayer { get; set; }

		#endregion Properties

		/// <summary>
		/// Initializes a new instance of the <b>GameSession</b> class.
		/// </summary>
		public GameSession()
		{
			// Initialize a new player with an empty name, 100 current and maximum hit points, 0 gold and experience points, and level 0.
			CurrentPlayer = new Player("", 100, 100, 0, 0, 0);
		}

		#region Methods for quitting the game

		/// <summary>
		/// Handles the action of a player quitting the game.<br/>
		/// It first asks the player for confirmation before terminating the application.
		/// </summary>
		public static void QuitGame()
		{
			// Check if the player confirms that they want to quit the game
			if (ConfirmQuitGame())
				// If the player confirms, exit the application
				Environment.Exit(0);
			else
				// If the player denies it, continue the game
				DisplayTextCenteredHorizontally("No");
		}

		/// <summary>
		/// Asks the player to confirm whether they want to quit the game.
		/// </summary>
		/// <returns>A boolean indicating whether the player confirmed (true) or denied (false) to quit the game.</returns>
		public static bool ConfirmQuitGame()
		{
			// Display the prompt
			DisplayTextCenteredHorizontally("Are you sure you want to quit the game? (y / n)", ConsoleColor.Blue);
			DisplayTextCenteredHorizontally("> ");

			while (true)
			{
				string? playerInputString = Console.ReadLine()?.ToLower();

				// If the player confirms that they want to quit the game, return true
				if (playerInputString == "y" || playerInputString == "yes")
					return true;
				// If the player denies quitting the game, return false
				else if (playerInputString == "n" || playerInputString == "no")
					return false;
				// If the player's input was invalid, display an error message and repeat the prompt
				else
				{
					Console.WriteLine("\n");
					DisplayTextCenteredHorizontally("That is not a valid input! Please type 'y' / 'yes' to confirm or 'n' / 'no' to cancel.", ConsoleColor.Red);
					DisplayTextCenteredHorizontally("> ");
				}
			}
		}

		#endregion Methods for quitting the game
	}
}