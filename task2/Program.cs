void ShowQuarter(int ax, int ay, int bx, int by, int az, int bz)
{
   double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
   Console.WriteLine($"Расстояние: {distance}");
}
int GetInput(string text)
{
   Console.WriteLine(text);
   return (Convert.ToInt32(Console.ReadLine()));
}
int ax = GetInput("Введите координату ax: ");
int ay = GetInput("Введите координату ay: ");
int bx = GetInput("Введите координату bx: ");
int by = GetInput("Введите координату by: ");
int az = GetInput("Введите координату az: ");
int bz = GetInput("Введите координату bz: ");
ShowQuarter(ax, ay, bx, by, az, bz);
