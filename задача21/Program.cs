// Задача 21
//Напишите программу, которая 
//принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату x3: ");
//int x3 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату y3: ");
//int y3 = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите координату z3: ");
//int z3 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11, int x21, int y21, int z21) // int x31, int y31, int z31)  
{
    int rangeX = x11 - x21; // x31;
    int rangeY = y11 - y21; // y31;
    int rangeZ = z11 - z21; // z31;
    double rangeQ = Math.Sqrt(rangeX*rangeX+rangeY*rangeY+rangeZ*rangeZ);
    return rangeQ;
}

double result = Range(x1,y1,z1,x2,y2,z2);//x3,y3,z3);
Console.Write($"A ({x1},{y1},{z1}); в ({x2},{y2},{z2}); -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
