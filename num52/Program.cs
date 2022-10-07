//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double[,] Vvod_massiva(int m,int n)
{
    double[,] Massiv = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Massiv[i,j]=rnd.Next(0,10);
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
void SredneeA(double [,] mass)
{
    double sum = 0;
    double result = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j< mass.GetLength(1); j++)
        {
            sum = sum + mass[i,j]; 
        }
        result = sum / mass.GetLength(1);
        Console.WriteLine("Среднее арифметическое " + (i+1) + " столбца: " + result);
        result = 0;
        sum = 0;
    }
}
 Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double [,] mas = Vvod_massiva(a,b);
Vivod_Massiva(mas,a,b);
SredneeA(mas);