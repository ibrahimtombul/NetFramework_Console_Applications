using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Klavyeden 10K kelimesi girilene kadar kelimeleri bir değişkene atıp ekrana yazdıran programın kodlarını yazınız.
			string kelime = "";
			string sonuc = "";
			do
			{
				Console.WriteLine("Tekrar");
				kelime = Console.ReadLine();
				sonuc += kelime + " - ";
			} while (kelime != "10K");

			Console.WriteLine("Sonuc: " + sonuc);
		}
	}
}
