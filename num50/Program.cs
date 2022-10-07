//Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] Vvod_massiva(int m,int n)
{
    int[,] Massiv = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            Massiv[i,j]=rnd.Next(0,100);
        }
    }
    return Massiv;
}
void Vivod_Massiva(int[,] mass, int m, int n)
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
void Poisk(int [,] mass,int x,int y)
{
    if (x > mass.GetLength(0) | y > mass.GetLength(1))
    {
        Console.WriteLine("Элемента " + x + " " + y + " в массиве нет. ");
    }
    else
    {
        Console.WriteLine(mass[x-1,y-1]);
    }
}
 Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int [,] mas = Vvod_massiva(a,b);
Vivod_Massiva(mas,a,b);
Console.WriteLine("Укажите какой элемент вам найти: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Poisk(mas,x,y);