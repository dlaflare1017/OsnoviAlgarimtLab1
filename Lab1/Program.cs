using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите возраст Тани: ");
        int ageTanya = int.Parse(Console.ReadLine());
        
        Console.Write("Введите возраст Мити: ");
        int ageMitya = int.Parse(Console.ReadLine());
        
        double averageAge = (ageTanya + ageMitya) / 2.0;
        
        double diffTanya = Math.Abs(ageTanya - averageAge);
        double diffMitya = Math.Abs(ageMitya - averageAge);
        
        Console.WriteLine($"Средний возраст: {averageAge:F2}");
        Console.WriteLine($"Разница возраста Тани от среднего: {diffTanya:F2}");
        Console.WriteLine($"Разница возраста Мити от среднего: {diffMitya:F2}");
    }
}
