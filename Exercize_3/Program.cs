void Exercize3()
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    Console.WriteLine("Введите значение: ");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x % 2 == 0)
    {
        Console.WriteLine("Число является четным " + x);
    }
    else
    {
        Console.WriteLine("Число четным не является " + x);
    }
}
Exercize3();