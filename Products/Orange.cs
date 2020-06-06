namespace Shop.Products
{
	class Orange : Product
	{
		public string Color { get; private set; }
		public string Flavor { get; private set; }
		public  override string Type
		{
			get
			{
				return "апельсин";
			}
			set
			{
				Type = "апельсин";

			}
		}

		public Orange(int price, string name, string manufacturer, string color, string flavour) : base(price, name, manufacturer)
		{
			Color = color;
			Flavor = flavour;
		}

		public override double SalePrice(User user)
		{
			return base.SalePrice(user);
		}

		public override string Info()
		{
			return base.Info()+$"Этот {Color} апельсин {Flavor}" ;
		}
	}
}
