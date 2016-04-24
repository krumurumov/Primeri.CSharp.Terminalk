using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефинирани на променливи
			int a = 0, b = 0;
			int sum = 0;
			string programe_name = "Modul02 - Примери";
			string programe_version = "1.0";

			//Събиране на числа
			a = 10;
			b = 5;

			sum = a + b;

			//Данни за програмата
			Console.WriteLine (programe_name);
			Console.WriteLine ( "\nВерсия: " + programe_version + "\n\n");

			//Писане в конзола
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine ( sum ); 

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b; 
			Console.WriteLine ("\nИзползване на -=");
			a -= b; 
			Console.WriteLine ( a );
			Console.WriteLine ("\nИзползване на *=");
			a *= b; 
			Console.WriteLine ( a );
			Console.WriteLine ("\nИзползване на ++");
			a++; 
			Console.WriteLine ( a );

			Console.WriteLine("Стандартно делене:" + (7 / 3). ToString()); //-> 2 (7/3=2,33)
			Console.WriteLine("Остатък от делене:"+ (7 % 3). ToString()); //-> 1 (1/3=0,333)

			 
		}
	}
}

 