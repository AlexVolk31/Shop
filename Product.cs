using System;

namespace Shop
{
	class Product
	{
		public virtual string Type
		{
			get
			{
				return "Продукт";
			}
			set
			{
				Type = "Продукт";

			}
		}

		public double Price { get; set; }
		public string Name { get; protected set; }
		public string Manufacturer { get; protected set; }

		public Product(int price, string name, string manufacturer)
		{
			Price = price;
			Name = name;
			Manufacturer = manufacturer;
		}


		public virtual double Delivery(User user)
		{
			Console.WriteLine($"Хотите заказать доставку, это будет стоить {Price * 0.1}$?\r\nЕсли да, то введите '1', иначе введите '0'.");
			if (Convert.ToInt32(Console.ReadLine()) == 0)
			{
				return 0;
			}

			Console.WriteLine($"Адрес доставки {user.Adress}");
			return Price * 0.1;

		}

		public virtual double SalePrice(User user)
		{
			if (user.Spent < 0)
			{
				return Price * 1.5;
			}

			if (user.Spent < 1000)
			{
				return Price;
			}

			if (user.Spent < 5000)
			{
				return Price * 0.9;
			}

			return Price * 0.8;
		}

		public virtual string Info()
		{
		   return $"Этот {Type} под названием {Name} стоит {Price}$\r\nПроизводитель: {Manufacturer}\r\n";

		}    
	
	}
}
