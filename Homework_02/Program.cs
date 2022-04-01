using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию:");
        string surname = Console.ReadLine();
        Console.WriteLine("Ваше хобби?");
        string hobby = Console.ReadLine();
        Console.WriteLine("Какая у вас зарплата?");
        string paycheck = Console.ReadLine();
        Console.WriteLine($"Ваше имя: {name}. Ваша фамилия: {surname}. Ваше хобби: {hobby}. Ваш доход: {paycheck}.");
    }
}