void Exercize2()
{
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел..
         
          Console.WriteLine("Введите первое значение: ");
          int a = Convert.ToInt32(Console.ReadLine());
         
          Console.WriteLine("Введите второе значение: ");
          int b = Convert.ToInt32(Console.ReadLine());
         
          Console.WriteLine("Введите третье значение: ");
          int c = Convert.ToInt32(Console.ReadLine());
           
           int max = a;

          if (a > max) max = a;
          if (b > max) max = b;
          if (c > max) max = c;
         
           
    Console.Write("max = ");
    Console.WriteLine(max);
}
Exercize2();