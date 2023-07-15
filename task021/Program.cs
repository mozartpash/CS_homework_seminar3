// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinata(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return distance;
}

int x1 = Coordinata("Введите первую координату точки '1' ");
int y1 = Coordinata("Введите вторую координату точки '1' ");
int z1 = Coordinata("Введите третью координату точки '1' ");
int x2 = Coordinata("Введите первую координату точки '2' ");
int y2 = Coordinata("Введите вторую координату точки '2' ");
int z2 = Coordinata("Введите третью координату точки '2' ");

Console.WriteLine("Расстояние между двумя точками: " + Math.Round(Distance(x1, y1, z1, x2, y2, z2), 3));


