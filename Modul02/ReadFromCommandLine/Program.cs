using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на промелниви
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write ( "Моля въведете a: " );
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ( "Резултата е a + b e " + (a + b).ToString () + "\n\n\n");
		}
	}
}
