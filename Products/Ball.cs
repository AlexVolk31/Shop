namespace Shop.Products
{
	class Ball : Product
	{
		public string Material { get; private set; }
		public double Size { get; private set; }
		public override string Type
		{
			get
			{
				return "мяч";
			}
			set
			{
				Type = "мяч";

			}
		}

		public Ball( int price, string name, string manufacturer, string material, int size) : base(price, name, manufacturer)
		{
			Material = material;
			Size = size;

		}


		public override double SalePrice(User user)
		{
			return base.SalePrice(user);
		}

		public override string Info()
		{
			return base.Info()+$"Материал: {Material}\r\nРазмер: {Size}" ;
		}
	}
}
