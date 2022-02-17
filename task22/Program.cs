//Задача 22: Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Задача 22: Найти расстояние между точками");
int [,]mass = new int[2, 3]; // чтобы превратить в вариант для 2д, тут нужно сменить 3 на 2

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1,10);
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    Console.Write($"Точка {i} - ");
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write($" {mass[i,j]} ");
    }
    Console.WriteLine();
}

double result = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    result += Math.Pow(mass[0,j]-mass[1,j],2);
}
result = Math.Sqrt(result);

Console.WriteLine("Расстояние между двумя точками равно " + result);
