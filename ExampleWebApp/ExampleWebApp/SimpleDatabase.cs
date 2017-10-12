using System;
using System.Collections.Generic;
using ExampleWebApp.Interfaces;

namespace ExampleWebApp
{
    public class SimpleDatabase : ISimpleDatabase
    {
        public SimpleDatabase()
        {
        }

        public List<string> GetAll()
        {
            List<string> data = new List<string>();

            data.Add("Hello");
            data.Add("Everyone");
            data.Add("My name is bob");

            return data;
        }
    }
}
