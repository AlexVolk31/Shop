using System;

namespace Shop
{
	class User
	{
		public string Name { get; private set; }
		public string Adress { get; private set; }
		public double Balance { get; private set; }
		public double Spent { get; private set; }

		public User(string[] input)
		{
			Name = input[0];
			Adress = input[1];
			Balance = Convert.ToInt32(input[2]);
			Spent = Convert.ToInt32(input[3]);
		}

		public void ReduceBalance(double price)
		{
			Balance -= price;
			Spent += price;
		}

	}
}
