using System;


namespace Exercise_3
{
    class Program
    {
       static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();
            myStruct.change = "Не изменено";
            myClass.change = "Не изменено";
            StruktTaker(myStruct);
            ClassTaker(myClass);
            Console.WriteLine($"Поле - {myClass.change}");
            Console.WriteLine($"Поле - {myStruct.change}");
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }

        //static void StruktTaker(ref MyStruct myStruct)
        //{
        //    myStruct.change = "Изменено"; 
        //}
        // А если не ссылке передавать то будет другой результат))
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
    }
}
