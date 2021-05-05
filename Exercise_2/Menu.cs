using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Menu
    {
        TimeTable time_table = new TimeTable();
                
        public void MenuItem()
        {
            int item = 0;
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("0 - добавить поезд в расписание\n1 - показать все расписание\n2 - показать расписание по номеру поезда\n3 - Выход из программы");
            try
            {
                item = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Вы выбрали пункт по умолчанию");
                Console.WriteLine();
                item = 1;
            }
            
            switch (item)
            {
                case 0:
                    {
                        AddTrain();
                        break;
                    }
                case 1:
                    {
                        Print();
                        break;
                    }
                case 2:
                    {
                        FindTrain();
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Default();
                        break;
                    }
            }
        }

        private void Default()
        {
            Console.WriteLine("Вы выбрали не существующий пункт меню");
            Console.ReadKey();
            Console.Clear();
            MenuItem();
        }
        private void FindTrain()
        {
            time_table.FindTimeTable();
            Console.ReadKey();
            Console.Clear();
            MenuItem();
        }

        private void Print()
        {
            time_table.PrintTimeTable();
            Console.ReadKey();
            Console.Clear();
            MenuItem();
        }
        private void AddTrain()
        {
            time_table.AddTimeTable();
            Console.Clear();
            MenuItem();
        }
    }
}
