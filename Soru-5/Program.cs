using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_5
{
	class Program
	{
		static void Main(string[] args)
		{

			// Bir dersten 2 sınav yapılacaktır, 2 savın ortalaması 50'den küçükse öğrenci 3. sınava girecektir.
			// Öğrenci 3. sınava girerse, tekrar 3 sınavın ortalaması hesaplanacaktır. Ortalama 50'den küçük ise 
			// "Başarısız Oldunuz", büyük ise "Tebrikler, geçtiniz" yazan program.

			int sinav1 = 0;
			int sinav2 = 0;
			int ortalama = 0;

			Console.WriteLine("1. Sınav Sonucu: ");
			sinav1 = int.Parse(Console.ReadLine());
			Console.WriteLine("2. Sınav Sonucu: ");
			sinav2 = int.Parse(Console.ReadLine());
			if ((sinav1 + sinav2) / 2<50)
			{
				Console.WriteLine("3. Sınav Sonucu: ");
				int sinav3 = int.Parse(Console.ReadLine());
				if ((sinav1 + sinav2 + sinav3) / 3 < 50)
				{
					Console.WriteLine("Başarısız Oldunuz.");
					Console.WriteLine("Ortalama: " + (sinav1 + sinav2 + sinav3) / 3);
				}
				else
				{
					Console.WriteLine("Tebrikler, Geçtiniz.");
					Console.WriteLine("Ortalama: "+(sinav1+sinav2+sinav3)/3);
				}
			}
			else
			{
				Console.WriteLine("Tebrikler, Geçtiniz.");
				Console.WriteLine("Ortalama: "+(sinav1+sinav2)/2);
			}

			Console.ReadKey();
		}
	}
}
