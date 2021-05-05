using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public (string, string, double) PrintNotebook(Notebook notebook)
        {
            var product = new Notebook(model, manufacturer, price);
            return (product.model, product.manufacturer, product.price);
        }
    }
}
