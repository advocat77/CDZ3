void Kub(int n)
{
   Console.WriteLine($"Числа в промежутке от 0 до {n}:, n");

   for (int i = 0; i < n; i++)
   {
      Console.WriteLine(i * i * i + ",");
   }
   Console.Write(n * n * n);
}
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
Kub(n);