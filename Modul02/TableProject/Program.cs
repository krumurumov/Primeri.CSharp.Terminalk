using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table [0, 0] = "Мартин"; table [0, 1] = "Симеонов"; table [0, 2] = "31";

			//Въвеждане на втори ред
			table [1, 0] = "Симеон"; table [1, 1] = "Мартинов"; table [1, 2] = "41";


			//Печат
			Console.Write ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table [_index, 0]) [0] + ". " + table [_index, 1] + ", " + table [_index, 2] + " г. "); 
		}

	}		

}
		


////			 Дефиниране на масив 
//string[] row = new string[3];
//row [0] = "Ред 1";
//row [1] = "Ред 2";
//row [2] = "Ред 3";
//
//Console.WriteLine ("Масив row: " + row[0] + "," +row[1] +"," + row[2] +"\n");
//
////			 Дефиниране на втори масив Split дефинира масива разделител единична кавичка в скобите и , за разделител между цифрите
//
//
//string[] parce = "1,2,3,4,5,6,7,8,9".Split (',');
//Console.WriteLine ("Броят на числата в масива е\n: " + "1,2,3,4,5,6,7,8,9\n\n e:" +parce.Length);
//
////			Стринг с нов сепаратор ","
//
//string list1 = string.Join (";", parce);
//Console.WriteLine ("Новият стринг е: \n" + list1 + "\n\n");
//
////			Задача от м 02 урок 7
////Да се напише програма, която създава масив с 20 елемента от целочислен 
////			тип и инициализира всеки от елементите със 
////			стойност равна на индекса на елемента, умножен по 5. Елементите на масива да
////			се изведат на конзолата. (Hint: Използвайте масив int[] и for цикъл.)
//
//int[] input = new int[21] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
//for (int i = 0; i < input[20]; i++)
//{
//	int multi;
//	multi = 5 * input[i];
//	Console.Write("{0},",multi);
//}
//Console.ReadLine();
//
////			Вариант на същата задача
//int [] Z1 = new int[20];
//for (int j =0; j<20; j++) 
//{
//	Z1 [j] = j*5;
//}
//for (int j = 0; j < 20; j++) {
//	Console.WriteLine ("За елемент " + j+ " от масива цифрата е: " + Z1 [j]+";");
//}
//
//Console.WriteLine ("\n");