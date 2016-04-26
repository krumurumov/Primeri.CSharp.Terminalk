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

			test = test.Replace( ", ", ";");
			Console.WriteLine ("Работа с Replace:" + test + "\n");

			Console.WriteLine ("3ти знак:" + test.Split (';')[2] );

//			/*Задачи Модул 02, Урок 06
// 		    1. Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World".
// 			2. Декларирайте променлива от тип object и й присвоете стойността на конкатенацията на 
// 				двете променливи от тип string (не изпускайте интервала по средата).
// 		    3. Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object. 
// 			( Hint: Трябва да използвате type casting.)
// 			4. Да се въведат от командния ред 1 число или цифра и 1 дума/стринг. След това да изведе дължината на получения стринг 
// 				при конкатенация, тоест броя на символите в новополучения стринг при конкатенация. (Hint: Трябва да преобразувате 
// 				int към String и след това да конкатениратe.)
// 			 */
			 
			 			//Решение 1 и 2
			 			string first = "Hello", second = "World";
			 			object	greating = (first + " " + second);
			 			Console.WriteLine ("\nИзписва променлива от тип object: " + greating + "\n");
			 
			 			//Решение 3 - и трите вършат работа, да проверя дали имат еднакъв смисъл...
			 
			 			Console.WriteLine ("\nИзписва string, който идва от object 1-ви вариант: \n" +  "\n");
			 
			 			string third1 = greating.ToString();
			 			Console.WriteLine ("\nИзписва string, който идва от object 2-ри вариант: \n" + third1 + "\n");
			 
			 			string third2 = (string)greating;
			 			Console.WriteLine ("\nИзписва string, който идва от object 3-ти вариант: \n" + third2 + "\n");
			 
			 			int aNumber = 0;
			 			string aWord = "";
			 			Console.Write ("Моля въведете желаното количество: ");
			 			aNumber = Convert.ToInt32(Console.ReadLine ());
			 			Console.Write ("Моля въведете желания продукт: ");
			 			aWord = (Console.ReadLine ());
			 //			string custOrder = aNumber + " " + aWord; -> работи и така. явно не схващам нещо или не съм използвала очакваната функция...
			 			string custOrder = aNumber.ToString() + " " + aWord;
			 			Console.WriteLine ("\nВие поръчахте: "  + custOrder);
			 			Console.WriteLine ("\nБрой символи в поръчката: "  + custOrder.Length);
		}
	}
}
