using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Bir alışveriş mağazasında 100 liraya kadar alışverişe yüzde 20, 100-200 lira arası alışverişe yüzde 30,
			// 200 liradan daha fazla alışverişlere yüzde 40 indirim yapılmaktadır.
			// Girilen alışveriş fiyatına göre indirimli fiyatı bulan programın kodlarını yazınız.
			Console.WriteLine("Ürün fiyatı Gir: ");
			double fiyat = double.Parse(Console.ReadLine());

			if (fiyat <= 100)
			{
				fiyat -= (fiyat / 100) * 20;
			}
			else if (fiyat > 100 && fiyat <= 200)
			{
				fiyat -= (fiyat / 100) * 30;
			}
			else
			{
				fiyat -= (fiyat / 100) * 40;
			}
			Console.WriteLine("indirimli fiyat: " + fiyat);
		}
	}
}
