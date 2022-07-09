int number = InputInt("Введите пятизначное число ");
int n1 = number/10000;
int n5 = number%10;

int n2 = (number/1000)%10;
int n4 = (number/10)%10;;


if(n1==n5 && n2==n4)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}







int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
