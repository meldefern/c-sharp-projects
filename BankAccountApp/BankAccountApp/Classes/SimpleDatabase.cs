using System;
using System.Collections.Generic;
using BankAccountApp.Interfaces;

namespace BankAccountApp
{
	public class SimpleDatabase : ISimpleDatabase
	{
		public SimpleDatabase()
		{
		}

		public List<string> GetAll()
		{
			List<string> data = new List<string>();

			data.Add("Transaction 1");
            data.Add("Transaction 2");

			return data;
		}
	}
}
