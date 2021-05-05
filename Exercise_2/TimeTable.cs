using System;


namespace Exercise_2
{
    class TimeTable
    {
        private Train[] trains = new Train[8];
        public int Counter { get; private set; } = 0;
        Random rnd = new Random();

        private Train AddTrain(string destination, int train_number, DateTime departure)
        {
            Train train;
            train.destination = destination;
            train.train_number = train_number;
            train.departure = departure;
            return train;
        }

        public Train[] AddTimeTable()
        {
            if (Counter < trains.Length)
            {
                Console.WriteLine("Введите станцию назначения");
                string destination = Console.ReadLine();
                Console.WriteLine("Введите номер поезда");
                int train_number = 0;
                if (Console.ReadLine() == "")
                {
                    train_number = rnd.Next(1000, 2000);
                }
                else train_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время отправления");
                DateTime departure = new DateTime();
                try
                {
                    departure = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    departure = DateTime.UtcNow;
                }
                trains[Counter] = AddTrain(destination, train_number, departure);
                Counter++;
            }
            else
            {
                Console.WriteLine($"Вы достигли максимального колличества записей - {Counter}");
                Console.WriteLine();
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                for (int i = 0; i < trains.Length; i++)
                {
                    for (int y = 0; y < trains.Length; y++)
                    {
                        if (trains[i].train_number < trains[y].train_number)
                        {
                            var x = trains[y];
                            trains[y] = trains[i];
                            trains[i] = x;
                        }
                    }
                }
            }
            return trains;
        }

        public void PrintTimeTable()
        {
            foreach (var item in trains)
            {
                Console.WriteLine($"Станция назначения - {item.destination}\nНомер поезда {item.train_number}\nВремя отправления {item.departure}");
                Console.WriteLine(new string('-', 30));
            }
        }
        
        public void FindTimeTable()
        {
            Console.WriteLine("Введите номер поезда");
            int train_number = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].train_number == train_number)
                {
                    check = true;
                    Console.WriteLine($"Станция назначения - {trains[i].destination}\n" +
                        $"Номер поезда {trains[i].train_number}\nВремя отправления {trains[i].departure}");
                    Console.WriteLine(new string('-', 30));
                }
            }
            if (!check)
            {
                Console.WriteLine($"Данный поезд № {train_number} в расписании не существует");
            }
        }
    }
}
