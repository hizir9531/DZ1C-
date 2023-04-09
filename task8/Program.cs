// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("введите число");

int N = 0;
//int n = 1

if  (int.TryParse(Console.ReadLine() , out N ) ) 
{
    for ( int n = 1; n <= N ;  n ++ )
    {
        if (n % 2 == 0) System.Console.Write(n+" ");
    }

}
else 
{
System.Console.WriteLine("число не корректно");
}