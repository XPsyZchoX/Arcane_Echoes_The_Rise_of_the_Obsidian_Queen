using System.Runtime.InteropServices;

namespace Arcane_Echoes_The_Rise_of_the_Obsidian_Queen
{
	/// <summary>
	/// This class is the starting point of execution for the application
	/// </summary>
	internal partial class EntryPoint
	{
		#region Open console window in full screen

		[LibraryImport("kernel32.dll")]
		private static partial IntPtr GetConsoleWindow();
		private static IntPtr ThisConsole = GetConsoleWindow();

		[LibraryImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static partial bool ShowWindow(IntPtr hWnd, int nCmdShow);

		private const int Maximize = 3;

		#endregion Open console window in full screen

		static void Main()
		{
			#region Open console window in full screen

			ShowWindow(ThisConsole, Maximize);

			#endregion Open console window in full screen
		}
	}
}