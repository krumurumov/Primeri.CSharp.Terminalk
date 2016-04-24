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
			Console.WriteLine ( "\nРезултата е a + b e " + (a + b).ToString () + "\n\n");

			string test = "1";
			test += ", 2";
			test += ", 100";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Събиране с += :" + test + "\n");

			test = test.Replace( ",",";");
			Console.WriteLine ("Работа с Replace:" + test + "\n");

			Console.WriteLine ("3ти знак:" + test.Split (';')[2] );
		}
	}
}
