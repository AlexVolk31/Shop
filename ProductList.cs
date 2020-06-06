using Shop.Products;
using System;


namespace Shop
{
    class ProductsList
    {

		static private Ball jumpball = new Ball(10, "попрыгунчик", "Ларёк", "резина", 1);

		static private Ball football = new Ball(2000, "футбольный мяч", "Puma", "пластик", 5);

		static private Ball steelball = new Ball(5000, "мяч для боулинга", "РОБ", "гипс", 6);

		static private Gamepad oldctrl = new Gamepad(4000, "Dualshok", "Sony", 200, 4000);

		static private Gamepad newctrl = new Gamepad(7000, "Dualsense", "Sony", 300, 5000);

		static private Orange fruit = new Orange(10000, "Опельсин", "AfricaFruit", "жёлтый", "кислый");

		static public Product[] Mass = new Product[] { jumpball, football, steelball, oldctrl, newctrl, fruit };
		

		static public void List()
		{
			for (int i = 0; i < Mass.Length; i++)
			{
				Console.WriteLine($"Товар номер {i + 1}:");
				Console.WriteLine(Mass[i].Info() + "\r\n");
			}
		}

		

	}
}
