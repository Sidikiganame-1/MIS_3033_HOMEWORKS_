using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__WPF___Classes_2
{
    public class Toy
    {
        public string Manufacturer;
        public string Name;
        public double Price;
        private string Aisle;

        public Toy()
        {
            this.Manufacturer = string.Empty;
            this.Name = string.Empty;
            this.Price = 0.00;
            this.Aisle = string.Empty;
        }

        public void GetAisle(string manufacturer, double price, string name)
        {
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Name = name;
        }
        public override string ToString() 
        {
            string Toy = ($"{Manufacturer}, {Name}, {Price}");
            return Toy;



        }

        
  

    }
}

