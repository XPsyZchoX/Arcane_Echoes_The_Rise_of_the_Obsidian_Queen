﻿using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.BasicUtilities;
using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.GameSession;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// A utility class responsible for managing the user interface for the console application.
	/// </summary>
	internal static class ConsoleUIManager
	{
		#region Methods that change the UI

		/// <summary>
		/// Guides the player to enter fullscreen mode in the console.<br/>
		/// Displays a message to instruct the player to press 'F11' to go into full screen mode, then waits for the 'Enter' key to be pressed to proceed.
		/// </summary>
		public static void EnterFullscreenMode()
		{
			// Display the prompt
			DisplayText("Please press 'F11' or 'Alt + Enter' to go into full screen mode, and then 'Enter' to continue...", ConsoleColor.DarkYellow);

			// Keep checking for user input until the 'Enter' key is pressed
			while (true)
			{
				ConsoleKeyInfo key = Console.ReadKey(true);

				// If the 'Enter' key is pressed, clear the console and exit the loop
				if (key.Key == ConsoleKey.Enter)
				{
					Console.Clear();
					break;
				}
			}
		}

		/// <summary>
		/// Displays the game's title screen, consisting of a preset ASCII art title and a prompt for the player to proceed.<br/>
		/// The title is displayed in dark green, and the prompt "Press any key to continue..." is shown inside a box in dark yellow.<br/>
		/// After a key is pressed, the console is cleared, and the game proceeds to the main menu.
		/// </summary>
		public static void DisplayTitleScreen()
		{
			// Represents the game title
			// Generated with: https://patorjk.com/software/taag/
			string gameTitle = @"
         ▄▄▄      ██▀███  ▄████▄  ▄▄▄      ███▄    █▓█████    ▓█████ ▄████▄  ██░ ██ ▒█████ ▓█████  ██████        ▄▄▄█████▓██░ ██▓█████     ██▀███  ██▓ ██████▓█████     ▒█████   █████▒   ▄▄▄█████▓██░ ██▓█████     ▒█████  ▄▄▄▄    ██████ ██▓█████▄ ██▓▄▄▄      ███▄    █      █████  █    ██▓█████▓█████ ███▄    █
        ▒████▄   ▓██ ▒ ██▒██▀ ▀█ ▒████▄    ██ ▀█   █▓█   ▀    ▓█   ▀▒██▀ ▀█ ▓██░ ██▒██▒  ██▓█   ▀▒██    ▒  ██▓   ▓  ██▒ ▓▓██░ ██▓█   ▀    ▓██ ▒ ██▓██▒██    ▒▓█   ▀    ▒██▒  ██▓██   ▒    ▓  ██▒ ▓▓██░ ██▓█   ▀    ▒██▒  ██▓█████▄▒██    ▒▓██▒██  ██▓██▒████▄    ██ ▀█   █    ▒██▓  ██▒██  ▓██▓█   ▀▓█   ▀ ██ ▀█   █
        ▒██  ▀█▄ ▓██ ░▄█ ▒▓█    ▄▒██  ▀█▄ ▓██  ▀█ ██▒███      ▒███  ▒▓█    ▄▒██▀▀██▒██░  ██▒███  ░ ▓██▄    ▒▓▒   ▒ ▓██░ ▒▒██▀▀██▒███      ▓██ ░▄█ ▒██░ ▓██▄  ▒███      ▒██░  ██▒████ ░    ▒ ▓██░ ▒▒██▀▀██▒███      ▒██░  ██▒██▒ ▄█░ ▓██▄  ▒██░██   █▒██▒██  ▀█▄ ▓██  ▀█ ██▒   ▒██▒  ██▓██  ▒██▒███  ▒███  ▓██  ▀█ ██▒
        ░██▄▄▄▄██▒██▀▀█▄ ▒▓▓▄ ▄██░██▄▄▄▄██▓██▒  ▐▌██▒▓█  ▄    ▒▓█  ▄▒▓▓▄ ▄██░▓█ ░██▒██   ██▒▓█  ▄  ▒   ██▒       ░ ▓██▓ ░░▓█ ░██▒▓█  ▄    ▒██▀▀█▄ ░██░ ▒   ██▒▓█  ▄    ▒██   ██░▓█▒  ░    ░ ▓██▓ ░░▓█ ░██▒▓█  ▄    ▒██   ██▒██░█▀   ▒   ██░██░██  ██░██░██▄▄▄▄██▓██▒  ▐▌██▒   ░██  █▀ ▓▓█  ░██▒▓█  ▄▒▓█  ▄▓██▒  ▐▌██▒
         ▓█   ▓██░██▓ ▒██▒ ▓███▀ ░▓█   ▓██▒██░   ▓██░▒████▒   ░▒████▒ ▓███▀ ░▓█▒░██░ ████▓▒░▒████▒██████▒▒ ██▓     ▒██▒ ░░▓█▒░██░▒████▒   ░██▓ ▒██░██▒██████▒░▒████▒   ░ ████▓▒░▒█░         ▒██▒ ░░▓█▒░██░▒████▒   ░ ████▓▒░▓█  ▀█▒██████▒░██░▒███▓▓░██░▓█   ▓██▒██░   ▓██░   ░▒███▒█▄▒▒█████▓░▒████░▒████▒██░   ▓██░
         ▒▒   ▓▒█░ ▒▓ ░▒▓░ ░▒ ▒  ░▒▒   ▓▒█░ ▒░   ▒ ▒░░ ▒░ ░   ░░ ▒░ ░ ░▒ ▒  ░▒ ░░▒░░ ▒░▒░▒░░░ ▒░ ▒ ▒▓▒ ▒ ░ ▒▓▒     ▒ ░░   ▒ ░░▒░░░ ▒░ ░   ░ ▒▓ ░▒▓░▓ ▒ ▒▓▒ ▒ ░░ ▒░ ░   ░ ▒░▒░▒░ ▒ ░         ▒ ░░   ▒ ░░▒░░░ ▒░ ░   ░ ▒░▒░▒░░▒▓███▀▒ ▒▓▒ ▒ ░▓  ▒▒▓  ▒░▓  ▒▒   ▓▒█░ ▒░   ▒ ▒    ░░ ▒▒░ ▒░▒▓▒ ▒ ▒░░ ▒░ ░░ ▒░ ░ ▒░   ▒ ▒
          ▒   ▒▒ ░ ░▒ ░ ▒░ ░  ▒    ▒   ▒▒ ░ ░░   ░ ▒░░ ░  ░    ░ ░  ░ ░  ▒   ▒ ░▒░ ░ ░ ▒ ▒░ ░ ░  ░ ░▒  ░ ░ ░▒        ░    ▒ ░▒░ ░░ ░  ░     ░▒ ░ ▒░▒ ░ ░▒  ░ ░░ ░  ░     ░ ▒ ▒░ ░             ░    ▒ ░▒░ ░░ ░  ░     ░ ▒ ▒░▒░▒   ░░ ░▒  ░ ░▒ ░░ ▒  ▒ ▒ ░ ▒   ▒▒ ░ ░░   ░ ▒░    ░ ▒░  ░░░▒░ ░ ░ ░ ░  ░░ ░  ░ ░░   ░ ▒░
          ░   ▒    ░░   ░░         ░   ▒     ░   ░ ░   ░         ░  ░        ░  ░░ ░ ░ ░ ▒    ░  ░  ░  ░   ░      ░      ░  ░░ ░  ░        ░░   ░ ▒ ░  ░  ░    ░      ░ ░ ░ ▒  ░ ░         ░      ░  ░░ ░  ░      ░ ░ ░ ▒  ░    ░░  ░  ░  ▒ ░░ ░  ░ ▒ ░ ░   ▒     ░   ░ ░       ░   ░ ░░░ ░ ░   ░     ░     ░   ░ ░
              ░  ░  ░    ░ ░           ░  ░        ░   ░  ░      ░  ░ ░      ░  ░  ░   ░ ░    ░  ░     ░                  ░  ░  ░  ░  ░      ░     ░       ░    ░  ░       ░ ░                     ░  ░  ░  ░  ░       ░ ░  ░           ░  ░    ░    ░       ░  ░        ░        ░      ░       ░  ░  ░  ░        ░
			";

			// Set the position of the cursor
			Console.SetCursorPosition(0, 24);

			// Display the game title and prompt
			DisplayText(gameTitle, ConsoleColor.DarkGreen);
			DisplayTextInsideBox("Press any key to continue...", ConsoleColor.DarkYellow);

			// Wait for a player response and clear the console
			Console.ReadKey();
			Console.Clear();
		}

		/// <summary>
		/// Displays the game's main menu.<br/>
		/// The player is prompted to enter a number corresponding to the menu options, and the corresponding method is called based on that choice.
		/// </summary>
		public static void DisplayMainMenu()
		{
			// Enable console scrolling
			Console.BufferHeight = short.MaxValue - 1;

			// Display the header and menu options
			DisplayHeader("-- MAIN MENU --");
			Console.WriteLine("\n\n");

			DisplayTextCenteredHorizontally("1. Start Game");
			DisplayTextCenteredHorizontally("2. Load Game");
			DisplayTextCenteredHorizontally("3. Settings");
			DisplayTextCenteredHorizontally("4. Achievements");
			DisplayTextCenteredHorizontally("5. Credits");
			DisplayTextCenteredHorizontally("6. Quit");
			Console.WriteLine("\n");

			// Display the prompt
			DisplayTextCenteredHorizontally("Which option would you like to choose? Please enter the menu item number.", ConsoleColor.Blue);

			// Make the cursor visible for the player's input
			Console.CursorVisible = true;

			// Loop the prompt until a valid input is received
			int playerInput;
			do
			{
				// Display the prompt and save the player's input
				DisplayTextCenteredHorizontally("> ");
				string? playerInputString = Console.ReadLine();
				Console.WriteLine("\n");

				// If the player's input is not a valid number or not in the menu option range, display an error message
				if (!int.TryParse(playerInputString, out playerInput) || playerInput < 1 || playerInput > 6)
				{
					Console.WriteLine("");
					DisplayTextCenteredHorizontally("That is not a valid input! Please enter a number between 1 and 6.", ConsoleColor.Red);
				}
			}
			while (playerInput < 1 || playerInput > 6);

			// Call the corresponding method based on the player's input
			switch (playerInput)
			{
				case 1:
					// StartGame();
					break;
				case 2:
					// LoadGame();
					break;
				case 3:
					// OpenSettings();
					break;
				case 4:
					// OpenAchievements();
					break;
				case 5:
					// ShowCredits();
					break;
				case 6:
					QuitGame();
					break;
			}

			// Disable console scrolling and make the cursor invisible
			Console.BufferHeight = Console.WindowHeight;
			Console.CursorVisible = false;
		}

		#endregion Methods that change the UI

		#region Utility Methods

		/// <summary>
		/// Displays a header consisting of a box containing the game title and the header text.<br/>
		/// The header text is displayed two lines under the box.
		/// </summary>
		/// <param name="headerText">The header text to display under the box containing the game title.</param>
		private static void DisplayHeader(string headerText)
		{
			// Represents the game title that is displayed in the box
			string gameTitle = "Arcane Echoes: The Rise of the Obsidian Queen";

			// Represents the margin between the border of the box and the game title
			int boxPadding = 20;

			// Represents the left and right padding between the border of the box and the game title, consisting of the repeated character ' '
			// The length of the string corresponds to 'boxPadding'
			string leftBoxPadding = new(' ', boxPadding);
			string rightBoxPadding = new(' ', boxPadding);

			// Represents the length of the border of the box
			int boxBorder = 10;

			// Represents the left and right borders of the box, consisting of the repeated character '*'
			// The length of the string corresponds to 'boxBorder'
			string leftBoxBorder = new('*', boxBorder);
			string rightBoxBorder = new('*', boxBorder);

			// Represents the total width of the box
			// The 'gameTitle.Length' reflects the length of the game title, whereas '(2 * boxPadding) + (2 * boxBorder)' accounts for the extra space added on both the left and right sides of the game title
			int boxWidth = gameTitle.Length + (2 * boxPadding) + (2 * boxBorder);

			// Represents the top and bottom borders of the box, consisting of the repeated character '*'
			// The length of the string corresponds to 'boxWidth'
			string topAndBottomBorder = new('*', boxWidth);

			// Centering the box horizontally and adjusting it vertically
			int paddingBetweenLeftConsoleBorderAndBox = (Console.WindowWidth - boxWidth) / 2;
			int paddingBetweenTopConsoleBorderAndBox = 10;

			// Save the original foreground color and set the new one
			ConsoleColor originalForegroundColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.DarkGreen;

			// Draw the box, including the game title
			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndBox, paddingBetweenTopConsoleBorderAndBox);
			Console.WriteLine(topAndBottomBorder);

			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndBox, paddingBetweenTopConsoleBorderAndBox + 1);
			Console.WriteLine(leftBoxBorder + leftBoxPadding + new string(' ', gameTitle.Length) + rightBoxPadding + rightBoxBorder);

			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndBox, paddingBetweenTopConsoleBorderAndBox + 2);
			Console.WriteLine(leftBoxBorder + leftBoxPadding + gameTitle + rightBoxPadding + rightBoxBorder);

			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndBox, paddingBetweenTopConsoleBorderAndBox + 3);
			Console.WriteLine(leftBoxBorder + leftBoxPadding + new string(' ', gameTitle.Length) + rightBoxPadding + rightBoxBorder);

			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndBox, paddingBetweenTopConsoleBorderAndBox + 4);
			Console.WriteLine(topAndBottomBorder);

			// Reset the foreground color
			Console.ForegroundColor = originalForegroundColor;

			// Centering the header text horizontally and adjusting it vertically
			int paddingBetweenLeftConsoleBorderAndHeaderText = paddingBetweenLeftConsoleBorderAndBox + (boxWidth / 2) - (headerText.Length / 2);
			int paddingBetweentopConsoleBorderAndHeaderText = paddingBetweenTopConsoleBorderAndBox + 7;

			// Display the header text
			Console.SetCursorPosition(paddingBetweenLeftConsoleBorderAndHeaderText, paddingBetweentopConsoleBorderAndHeaderText);
			Console.WriteLine(headerText);
		}

		#endregion Utility Methods
	}
}