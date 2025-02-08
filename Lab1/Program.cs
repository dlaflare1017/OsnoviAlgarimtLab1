using System;

class Program
{
    static void Main()
    {
        // Ввод возрастов Тани и Мити
        Console.Write("Введите возраст Тани: ");
        int ageTanya = int.Parse(Console.ReadLine());
        
        Console.Write("Введите возраст Мити: ");
        int ageMitya = int.Parse(Console.ReadLine());
        
        // Вычисление среднего возраста
        double averageAge = (ageTanya + ageMitya) / 2.0;
        
        // Вычисление разницы возрастов с средним значением
        double diffTanya = Math.Abs(ageTanya - averageAge);
        double diffMitya = Math.Abs(ageMitya - averageAge);
        
        // Вывод результатов
        Console.WriteLine($"Средний возраст: {averageAge:F2}");
        Console.WriteLine($"Разница возраста Тани от среднего: {diffTanya:F2}");
        Console.WriteLine($"Разница возраста Мити от среднего: {diffMitya:F2}");
    }
}
