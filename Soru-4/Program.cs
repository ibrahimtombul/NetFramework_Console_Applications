using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Klavyeden girilen 10 sayıyı diziye atıp aritmetik ortalamasını bulup sonucu ekrana yazdan program.

			int[] sayilar = new int[10];
			int Toplam = 0;
			for (int i = 0; i < sayilar.Length; i++)
			{
				Console.WriteLine(i+1+". Sayıyı Gir: ");
				sayilar[i] = int.Parse(Console.ReadLine());
				Toplam += sayilar[i];
			}
			Console.WriteLine("Ortalama: "+Toplam/sayilar.Length);

			Console.ReadLine();
		}
	}
}
