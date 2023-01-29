using System;
using System.Diagnostics;

namespace Encapsulation
{
	public class Invoice
	{
		int account;
		string customer;
		string provider;

		public Invoice(int account, string customer, string provider)
		{
			this.account = account;
			this.customer = customer;
			this.provider = provider;
		}

		public string Article { get; set; }

		public int Quantity { get; set; }

		public decimal Price { get; set; }

		public void CostCalculation(bool needEdv)
        {
            if (needEdv==true)
            {
                Console.WriteLine($"Məhsul: {Article}\nMəhsulun dəyəri: {Price*Quantity*(decimal)1.18}");
            }
            else
            {
                Console.WriteLine($"Məhsul: {Article}\nMəhsulun dəyəri: {Price * Quantity}");
            }
        }
    }
}

