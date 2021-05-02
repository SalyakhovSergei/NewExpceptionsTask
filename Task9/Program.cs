using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception myException = new Exception("Собственный эксепшен");
            
            DivideByZeroException divideException = new DivideByZeroException();
            FormatException formatException = new FormatException("Введите число!");
            ArgumentNullException argumentNullException = new ArgumentNullException();
            IndexOutOfRangeException indexOutOfRangeException = new IndexOutOfRangeException();

            Exception[] exceptionArray = new Exception[5];
            exceptionArray[0] = myException;
            exceptionArray[1] = divideException;
            exceptionArray[2] = formatException;
            exceptionArray[3] = argumentNullException;
            exceptionArray[4] = indexOutOfRangeException;

            Console.WriteLine("Введите числа от 1 до 100, которые вы хотите поделить");
            double i;
            double j;

            try
            {
                i = Convert.ToDouble(Console.ReadLine());
                j = Convert.ToDouble(Console.ReadLine());
                
                if (i>100 || j>100)
                {
                    throw myException;
                }

                Console.WriteLine(i / j);
                throw exceptionArray[1];
                throw exceptionArray[2];
                throw exceptionArray[3];
                throw exceptionArray[4];
            }
            catch (Exception ex) when (ex is FormatException)
            {
                Console.WriteLine(exceptionArray[2].Message);
            }
            catch (Exception)
            {
                Console.WriteLine(myException.Message);
                
            }

        }
    }
}

