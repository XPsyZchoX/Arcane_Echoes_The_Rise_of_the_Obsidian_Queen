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
		/// Displays the specified text in the console.<br/>
		/// The color of the text and a typing effect can be optionally specified.
		/// </summary>
		/// <param name="text">The text to be displayed.</param>
		/// <param name="textColor">The color to display the text in. The default is white.</param>
		/// <param name="textSpeed">The speed of the typing effect. The default is 0 (instant display).</param>
		public static void DisplayText(string text, ConsoleColor textColor = ConsoleColor.White, int textSpeed = 0)
		{
			// Set the text color
			Console.ForegroundColor = textColor;

			// Display the text
			if (textSpeed > 0)
			{
				foreach (char character in text)
				{
					Console.Write(character);
					Thread.Sleep(textSpeed);
				}

				// Move the cursor to a new line after writing the characters
				Console.WriteLine();
			}
			else
				Console.WriteLine(text);

			// Reset the text color
			Console.ResetColor();
		}

		/// <summary>
		/// Displays the specified text in the console, centered horizontally.<br/>
		/// The color of the text and a typing effect can be optionally specified.
		/// </summary>
		/// <param name="text">The text to be displayed.</param>
		/// <param name="textColor">The color to display the text in. The default is white.</param>
		/// <param name="textSpeed">The speed of the typing effect. The default is 0 (instant display).</param>
		public static void DisplayTextCenteredHorizontally(string text, ConsoleColor textColor = ConsoleColor.White, int textSpeed = 0)
		{
			// Set the text color
			Console.ForegroundColor = textColor;

			// Determine and write the padding to the left
			int leftPadding = (Console.WindowWidth - text.Length) / 2;
			Console.Write(new String(' ', leftPadding));

			// If the text equals "> ", it should be written without a new line
			if (text == "> ")
			{
				Console.Write(text);
				return;
			}

			// Display the text
			if (textSpeed > 0)
			{
				foreach (char character in text)
				{
					Console.Write(character);
					Thread.Sleep(textSpeed);
				}

				// Move the cursor to a new line after writing the characters
				Console.WriteLine();
			}
			else
				Console.WriteLine(text);

			// Reset the text color
			Console.ResetColor();
		}

		/// <summary>
		/// Displays the specified text inside a box in the console.<br/>
		/// The color of the text and box, as well as the background color and the top padding can be optionally specified.
		/// </summary>
		/// <param name="text">The text to be displayed.</param>
		/// <param name="textAndBoxColor">The color to display the text and box in. The default is white.</param>
		/// <param name="backgroundColor">The color of the box's background. The default is black.</param>
		/// <param name="topPadding">The top padding between the top of the console and the box. The default is 44.</param>
		public static void DisplayTextInsideBox(string text, ConsoleColor textAndBoxColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black, int topPadding = 44)
		{
			// Represents the margin between the border of the box and the message that is displayed inside
			int boxPadding = 4;

			// Represents the left and right padding between the border of the box and the message that is displayed inside, consisting of the repeated character ' '
			// The length of the string corresponds to 'boxPadding'
			string leftboxPadding = new(' ', boxPadding);
			string rightboxPadding = new(' ', boxPadding);

			// Represents the total width of the content inside the box
			// The 'text.Length' reflects the actual content that will be displayed, whereas '2 * boxPadding' accounts for the extra space added on both the left and right sides of the text
			int boxContentWidth = text.Length + (2 * boxPadding);

			// Represents the top and bottom border of the box, consisting of the repeated character '═'
			// The length of the string corresponds to 'boxContentWidth'
			string topAndBottomBorder = new('═', boxContentWidth);

			// Centering the box horizontally
			int leftPadding = (Console.WindowWidth - boxContentWidth) / 2;

			// Save the original console settings
			int originalCursorLeftPosition = Console.CursorLeft;
			int originalCursorTopPosition = Console.CursorTop;
			ConsoleColor originalForegroundColor = Console.ForegroundColor;
			ConsoleColor originalBackgroundColor = Console.BackgroundColor;

			// Set the colors
			Console.ForegroundColor = textAndBoxColor;
			Console.BackgroundColor = backgroundColor;

			// Draw the box, including the content
			Console.SetCursorPosition(leftPadding, topPadding);
			Console.WriteLine("╔" + topAndBottomBorder + "╗");

			Console.SetCursorPosition(leftPadding, topPadding + 1);
			Console.Write("║" + leftboxPadding + text + rightboxPadding + "║");

			Console.SetCursorPosition(leftPadding, topPadding + 2);
			Console.WriteLine("╚" + topAndBottomBorder + "╝");

			// Reset the console settings
			Console.SetCursorPosition(originalCursorLeftPosition, originalCursorTopPosition);
			Console.ForegroundColor = originalForegroundColor;
			Console.BackgroundColor = originalBackgroundColor;
		}

		#endregion Methods
	}
}