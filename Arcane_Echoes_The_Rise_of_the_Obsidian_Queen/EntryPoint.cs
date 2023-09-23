using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.ConsoleUIManager;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// This class is the starting point of execution for the application.
	/// </summary>
	internal partial class EntryPoint
	{
		/// <summary>
		/// The main method for the application's entry point.
		/// </summary>
		static void Main()
		{
			// Disable console scrolling
			Console.BufferHeight = Console.WindowHeight;

			EnterFullscreenMode();

			// Make the cursor invisible
			Console.CursorVisible = false;

			DisplayTitleScreen();
			DisplayMainMenu();
		}
	}
}