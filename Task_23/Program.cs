int number = InputInt("Введите число ");
int minNumber = 1;

while (minNumber <= number )
{
    int n = minNumber*minNumber*minNumber;
    Console.Write(n + " ");
    minNumber++;
}





int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


