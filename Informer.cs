using System;

namespace Shop
{
	class Informer
	{
		
		public void Buy(User user, Product product)
		{


			if (user.Balance >= product.SalePrice(user))
			{
				Console.WriteLine($"Покупатель {user.Name} покупает {product.Name} за {product.Price}$");
				if (product.SalePrice(user) != product.Price)
				{
					Console.WriteLine($"Цена со скидкой: {product.SalePrice(user)}");
				}
				Console.WriteLine($"Итоговая цена: {product.SalePrice(user)+product.Delivery(user)}");;
				user.ReduceBalance(product.SalePrice(user));
				Console.WriteLine($"Остаток по счёту: {user.Balance}$\r\n");
				Console.WriteLine("Покупка совершена! Можете продолжить шопинг\r\n");

			} else
            {
				Console.WriteLine($"Недостаточно средств: {user.Balance}/{product.SalePrice(user)}\r\n");
            }
		}

		public string[] Greeting()
        {
			string[] mass = new string[4];
			

			Console.WriteLine("Приветствую тебя, путник. Добро пожаловать в мой магазин!\r\nПредствься.");
			Console.Write("Мое имя ");
			mass[0] = Console.ReadLine();
			Console.Write("Укажи адрес доставки: ");
			mass[1] = Console.ReadLine();
			Console.WriteLine("Сколько монет ты принёс с собой, путник?") ;
			Console.Write("У меня их всего ");
			mass[2] = Console.ReadLine();
			Console.Write("Сколько монет ты уже потратил в нашем магазине?\r\nЯ потратил ");
			mass[3] = Console.ReadLine();
			Console.WriteLine();



			return mass;
        }
	}
}
