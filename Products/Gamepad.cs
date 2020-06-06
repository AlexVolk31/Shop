using System.Buffers.Text;

namespace Shop.Products
{
	class Gamepad : Product
	{
		public int Sensivity { get; private set; }
		public int Capasity { get; private set; }
		public override string Type
		{
			get
			{
				return "геймпад";
			}
			set
			{
				Type = "геймпад";

			}
		}


		public Gamepad( int price, string name, string manufacturer, int sensivity, int capasity) : base(price, name, manufacturer)
		{
			Sensivity = sensivity;
			Capasity = capasity;

		}

		public override double SalePrice(User user)
		{
			return Price*0.8;
		}

		public override string Info()
		{
			return base.Info()+$"Чувствительность стиков: {Sensivity}\r\nЁмкость аккумулятора {Capasity} mAh" ;
		}
	}
}
