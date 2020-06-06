using Shop.Products;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop
{
	class Program
    {
        private const string Help =
@"Если хочешь что - то купить, то введи его номер.
Если захочешь выйти введи 0.
Если захочешь увидеть это сообщение с подсказками введи -1
Если захочешь узнать свой баланс введи -2
Если захочешь посмотреть список товаров введи -3
";

        static void Main(string[] args)
        {

			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;

            //string[] data = { "Вася", "Омск", "10000", "200" };

            Informer seller = new Informer();

			User user = new User(seller.Greeting());

			ProductsList.List();

			Console.WriteLine(Help);

			while (true)
			{
				int input = Convert.ToInt32(Console.ReadLine());

				if (input == 0)
				{
					break;
				}
				else
				{
					switch (input)
					{
						case -1:
							Console.WriteLine(Help);
							break;

						case -2:
							Console.WriteLine($"Ваш баланс {user.Balance}$\r\n");
							break;

						case -3:
							ProductsList.List();
							break;

						default:
							seller.Buy(user, ProductsList.Mass[input-1]);
							break;
					}
				}
			}
			Console.ReadKey();
		}



	}
	
} 