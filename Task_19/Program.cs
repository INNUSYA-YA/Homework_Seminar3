int number = InputInt("Введите пятизначное число ");
int n1 = number/10000;
int n5 = number%10;
int number1 = number;
int count = 0;
int n2 = 0;
int n4 = 0;

while(number>0)
{
number/=10;
count++;
if(count==3)
{
    n2 = number%10;
}
if(count==1)
{
    n4 = number%10;
}
}
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
