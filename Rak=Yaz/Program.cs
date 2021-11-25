using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rak_Yaz
{
	class Program
	{

		static int sayi;
		static void Main(string[] args)
		{
			
			
			Console.Write("Sayı Giriniz=");
			sayi = Convert.ToInt32(Console.ReadLine());
			if (sayi != 0)
			{
				switch(sayi / 100)
			{
				case 1: Console.Write("Yüz"); break;
				case 2: Console.Write("İkiyüz"); break;
				case 3: Console.Write("Üçyüz"); break;
				case 4: Console.Write("Dörtyüz"); break;
				case 5: Console.Write("Beşyüz"); break;
				case 6: Console.Write("Altıyüz"); break;
				case 7: Console.Write("Yediyüz"); break;
				case 8: Console.Write("Sekizyüz"); break;
				case 9: Console.Write("Dokuzyüz"); break;

				}
				switch ((sayi % 100) / 10)
				{
					case 1: Console.Write("On"); break;
					case 2: Console.Write("Yirmi"); break;
					case 3: Console.Write("Otuz"); break;
					case 4: Console.Write("Kırk"); break;
					case 5: Console.Write("Elli"); break;
					case 6: Console.Write("Altmış"); break;
					case 7: Console.Write("Yetmiş"); break;
					case 8: Console.Write("Seksen"); break;
					case 9: Console.Write("Doksan"); break;
				}
				switch (sayi % 10)
				{
					case 1: Console.Write("Bir"); break;
					case 2: Console.Write("İki"); break;
					case 3: Console.Write("Üç"); break;
					case 4: Console.Write("Dört"); break;
					case 5: Console.Write("Beş"); break;
					case 6: Console.Write("Altı"); break;
					case 7: Console.Write("Yedi"); break;
					case 8: Console.Write("Sekiz"); break;
					case 9: Console.Write("Dokuz"); break;
				}
			}
			if (sayi == 0)
			{
				Console.WriteLine("Lütfen 0 dan Farklı Sayı Giriniz");
				Main(null);
			

			}

			Console.ReadLine();
		}
	}
}
