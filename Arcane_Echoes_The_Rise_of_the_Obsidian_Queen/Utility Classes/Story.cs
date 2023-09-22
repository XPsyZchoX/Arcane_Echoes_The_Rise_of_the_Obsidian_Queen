using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.BasicUtilities;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// A utility class responsible for managing the display of various game stages.
	/// </summary>
	internal static class Story
	{
		/// <summary>
		/// Displays the game's title screen, consisting of a preset ASCII art title and a prompt for the player to proceed.<br/>
		/// The title is displayed in dark green, and the prompt "Press any key to continue..." is shown inside a box in dark yellow.<br/>
		/// After a key is pressed, the console is cleared, and the game proceeds to the main menu.
		/// </summary>
		public static void TitleScreen()
		{
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

			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 24);
			DisplayText(gameTitle, ConsoleColor.DarkGreen);
			DisplayTextInsideBox("Press any key to continue...", ConsoleColor.DarkYellow);
			Console.ReadKey();
			Console.Clear();
		}

		public static void MainMenu()
		{

		}
	}
}