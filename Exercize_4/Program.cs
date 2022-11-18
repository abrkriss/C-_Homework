void Exercize4()
{
    //Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите значение окончания исчисления на отрезке ");
    int num = Convert.ToInt32(Console.ReadLine());
        int result = 1;
       
        if (result == 1)

        {
         result += 1;
        }

        while (result <= num)

        {
            Console.WriteLine("Четные значения на отрезке: " + result);
            result += 2;
        }
}
Exercize4();