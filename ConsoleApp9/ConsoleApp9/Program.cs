using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    float rubInWallet, usdInWallet;

			float wantedRubToUsdConvert;
			float wantedUsdToRubConvert;

			int convertType;

			float usdCost = 72.41f;
			float rubCost = 0.014f;

			Console.Write("Введите ваше количевство рублей:");
			rubInWallet = Convert.ToSingle(Console.ReadLine());
			Console.Write("Введите ваше количевство долларов:");
			usdInWallet = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Что вы хотите перевести? Что бы перевести рубли в доллары, напишите 1. Если доллары в рубли, то 2");
			convertType = Convert.ToInt32(Console.ReadLine());

			switch (convertType)
			{
				case 1:
					Console.WriteLine("Вы выбрали конвертацию рублей в доллары");
					Console.Write("Введите количевство рублей для обмена в доллары:");
					wantedRubToUsdConvert = Convert.ToSingle(Console.ReadLine());
					if (wantedRubToUsdConvert <= rubInWallet)
					{
						usdInWallet += wantedRubToUsdConvert / usdCost;
						rubInWallet -= wantedRubToUsdConvert;

						Console.WriteLine($"Всё прошло успешно. Теперь у вас {usdInWallet} долларов, и {rubInWallet} рублей соответственно.");
					}
					else
					{
						Console.WriteLine("Что-то пошло не так, попробуйте ещё раз, код ошибки - chtoZaScam");
					}

					break;
				case 2:
					Console.WriteLine("Вы выбрали конвертацию долларов в рубли");
					Console.Write("Введите количество рублей для обмена в рубли:");
					wantedUsdToRubConvert = Convert.ToSingle(Console.ReadLine());
					if (wantedUsdToRubConvert <= usdInWallet)
					{
						rubInWallet += wantedUsdToRubConvert / rubCost;
						usdInWallet -= wantedUsdToRubConvert;

						Console.WriteLine($"Всё прошло успешно. Теперь у вас {rubInWallet} рублей, и {usdInWallet} рублей соответственно.");
					}
					else
					{
						Console.WriteLine("Что-то пошло не так, попробуйте ещё раз, код ошибки - chtoZaScam");
					}

					break;
				default:
					Console.WriteLine("Что-то пошло не так, попробуйте ещё раз, код ошибки - vsoSlomalosb");
					break;
			}

			Console.ReadKey();
		}
	}
}
