using static Arcane_Echoes_The_Rise_of_the_Obsidian_Queen.Story;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// This class is the starting point of execution for the application
	/// </summary>
	internal partial class EntryPoint
	{
		static void Main()
		{
			// Disable scrolling in the console
			Console.BufferHeight = Console.WindowHeight;

			EnterFullscreenMode();
			DisplayTitleScreen();
			DisplayMainMenu();
		}
	}
}