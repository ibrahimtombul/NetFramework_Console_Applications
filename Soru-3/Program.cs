using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kavyeden iki string girişi sağlanacaktır. Eğer kelimeler aynı ise ekrana 'Kelimeler Aynı' değilse 'Kelimeler Farklı'
			// yazan programın kodlarını yazınız.
			Console.WriteLine("1. Kelime Girin :");
			string kelime1 = Console.ReadLine();
			Console.WriteLine("2. Kelime Girin :");
			string kelime2 = Console.ReadLine();

			if (kelime1 == kelime2)
			{
				Console.WriteLine("Kelimeler Aynı");
			}
			else
			{
				Console.WriteLine("Kelimeler Farklı");
			}
			Console.ReadKey();
		}
	}
}
