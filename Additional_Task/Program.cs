using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Lenovo Yoga Slim 7i 14IIL05 82A10085RU", "New Technology Developer Inc.", 102990);
            var product = notebook.PrintNotebook(notebook);
            Console.WriteLine($"Модель - {product.Item1}\nПроизводитель - {product.Item2}\nЦена - {product.Item3} рублей");
            Console.ReadKey();
        }
    }
}
