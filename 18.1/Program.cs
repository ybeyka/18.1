using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть арифметичний вираз:");
        string expression = Console.ReadLine();

        try
        {
            object computationResult = new DataTable().Compute(expression, null);
            double result = Convert.ToDouble(computationResult);

            if (double.IsInfinity(result) || double.IsNaN(result))
            {
                Console.WriteLine("Помилка: ділення на 0.");
            }
            else
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }
    }
}
