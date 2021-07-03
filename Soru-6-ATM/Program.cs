using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_6_ATM
{
	class Program
	{
		static void Main(string[] args)
		{
			// Bankamatik Sistemi Yazınız. (Tek kullanıcılı)
			string username = "";
			string password = "";
			int islem = 0;
			double bakiye = 1000;
			bool durum = false;

			Console.WriteLine("\tT Bank'a Hoşgeldiniz.\n");
			Console.WriteLine("\tLütfen Giriş Yapınız:\n");
			Console.Write("\tKullanıcı Adı: ");
			username = Console.ReadLine();
			Console.Write("\tŞifre: ");
			password = Console.ReadLine();
			if (username == "ibrahim" && password == "654321")
			{
				do
				{
					Console.Clear();
					Console.WriteLine("\t"+username+" Hoşgeldiniz. \n");
					Console.WriteLine("\t[1]Para Yatır\n\t[2]Para Çek\n\t[3]Çıkış");
					Console.Write("\tİşlem numarasını giriniz: ");
					islem = int.Parse(Console.ReadLine());
					Console.Clear();
					switch (islem)
					{
						case 1:
							Console.WriteLine("\tBakiye: " + bakiye);
							Console.WriteLine("\tYatırmak istediğiniz tutarı giriniz: ");
							Console.Write("\tTutar: ");
							int tutar = int.Parse(Console.ReadLine());
							bakiye += tutar;
							Console.WriteLine("\tGüncel Bakiyeniz: " + bakiye);
							Console.WriteLine("\t[1]Menüye dön\n\t[2]Çıkış Yap");
							islem = int.Parse(Console.ReadLine());
							if (islem == 1)
							{
								durum = true;
							}
							else
							{
								Environment.Exit(0);
							}
							
							break;
						case 2:
							Console.WriteLine("\tBakiye: " + bakiye);
							Console.WriteLine("\tÇekmek istediğiniz tutarı giriniz: ");
							int tutar2 = int.Parse(Console.ReadLine());
							if (tutar2 <= bakiye)
							{
								bakiye -= tutar2;
								Console.WriteLine("\tGüncel Bakiyeniz: " + bakiye);
								Console.WriteLine("\t[1]Menüye dön\n\t[2]Çıkış Yap");
								islem = int.Parse(Console.ReadLine());
								if (islem == 1)
								{
									durum = true;
								}
								else
								{
									Environment.Exit(0);
								}
							}
							else
							{
								Console.Clear();
								Console.WriteLine("\tYeterli Bakiyeniz bulunmamaktadır. !!");
								Console.WriteLine("\tGüncel Bakiyeniz: " + bakiye);
								Console.WriteLine("\t[1]Menüye dön\n\t[2]Çıkış Yap");
								islem = int.Parse(Console.ReadLine());
								if (islem == 1)
								{
									durum = true;
								}
								else
								{
									Environment.Exit(0);
								}
							}
							break;
						case 3:
							Environment.Exit(0);
							break;
					}

				} while (durum);
			}
			else
			{
				Console.WriteLine("\tGiriş Bilgileri Yanlış.");
			}
		}
	}
}
