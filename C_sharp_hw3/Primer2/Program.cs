// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

const int X = 0;
const int Y = 1;
const int Z = 2;

int[] InputCoords(string message)
{
    int[] numCoord = new int[3];
    for (int i = 0; i < numCoord.Length; i++)
    {
        System.Console.Write($"{message} {i}-я ");
        string value = Console.ReadLine();
        numCoord[i] = int.Parse(value);
    }
    return numCoord;
}

double Power2FromPoint(double C1, double C2)
{
    double distanceCoords = C1 - C2;
    return distanceCoords * distanceCoords;
}
double LineLong(int[] point1, int[] point2)
{
    double LineLong = Math.Sqrt(Power2FromPoint(point1[X], point2[X]) + Power2FromPoint(point1[Y], point2[Y]) + Power2FromPoint(point1[Z], point2[Z]));
    return LineLong;
}
int[] point1 = InputCoords("Координаты первой точки");
int[] point2 = InputCoords("Координаты второй точки");
System.Console.Write($"Расстояние между точками {LineLong(point1, point2)}");