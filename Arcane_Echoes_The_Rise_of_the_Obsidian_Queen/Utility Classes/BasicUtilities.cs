namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// A utility class that provides a set of basic and common methods.<br/>
	/// It acts as a centralized location for commonly used, often-repeated, or general-purpose code to promote reuse and code organization.
	/// </summary>
	internal static class BasicUtilities
	{
		#region Variables

		/// <summary>
		/// Represents an instance of the <b>Random</b> class used for generating random numbers.
		/// </summary>
		private static readonly Random _randomNumberGenerator = new();

		#endregion Variables

		#region Methods

		/// <summary>
		/// Generates and returns a random integer between the specified minimum value and maximum value.
		/// </summary>
		/// <param name="minimumValue">The lower bound of the random number returned.</param>
		/// <param name="maximumValue">The upper bound of the random number returned.</param>
		/// <returns>A random integer that is within the specified bounds.</returns>
		public static int GenerateNumberBetweenMinAndMax(int minimumValue, int maximumValue)
		{
			return _randomNumberGenerator.Next(minimumValue, maximumValue + 1);
		}

		/// <summary>
		/// Displays the specified text in the console with a typing effect.<br/>
		/// The speed of the typing effect and the color of the text can be optionally specified.
		/// </summary>
		/// <param name="text">The text to be displayed in the console.</param>
		/// <param name="textSpeed">The speed of the typing effect. The default is 0 (instant display).</param>
		/// <param name="consoleColor">The color to display the text in. The default is white.</param>
		public static void DisplayDialog(string text, int textSpeed = 0, ConsoleColor consoleColor = ConsoleColor.White)
		{
			Console.ForegroundColor = consoleColor;
			foreach (char character in text)
			{
				Console.Write(character);
				Thread.Sleep(textSpeed);
			}
			Console.ResetColor();
		}

		#endregion Methods
	}
}