   int xOne = InputInt("Введите X1: ");
   int yOne = InputInt("Введите Y1: ");
   int zOne = InputInt("Введите Z1: ");
   int xTwo = InputInt("Введите X2: ");
   int yTwo = InputInt("Введите Y2: ");
   int zTwo = InputInt("Введите Z1: ");
   

int firstSegment = xTwo - xOne;
int secondSegment = yTwo - yOne;
int ThirdSegment = zTwo - zOne;
int sumQuadro = firstSegment*firstSegment+secondSegment*secondSegment+ThirdSegment*ThirdSegment;
double sqrt = Math.Sqrt(sumQuadro);

Console.WriteLine("Расстояние между точками " + sqrt);

int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}