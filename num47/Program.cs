//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] Vvod_massiva(int m,int n)
{
    double[,] Massiv = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Massiv[i,j]=Math.Round(rnd.Next(-100,100)+rnd.NextDouble(),2);
        }
    }
    return Massiv;
}
void Vivod_Massiva(double[,] mass, int m, int n)
{
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Console.Write(mass[i,j] + "\t ");
        }
        Console.WriteLine(" ");
    }
}
 Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double [,] mas = Vvod_massiva(a,b);
Vivod_Massiva(mas,a,b);