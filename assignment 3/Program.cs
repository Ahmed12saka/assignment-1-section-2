Console.Write("enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the fourth number: ");
double num4 = Convert.ToDouble(Console.ReadLine());

if(num1 > num2 && num1 > num3 && num1 > num4)
{
    Console.WriteLine("The biggest number is: " + num1);
}else if(num2 > num1 && num2 > num3 && num2 > num4)
{
    Console.WriteLine("The biggest number is: " + num2);
}
else if(num3 > num1 && num3 > num2 && num3 > num4)
{
    Console.WriteLine("The biggest number is: " + num3);
}
else
{
    Console.WriteLine("wrong");
}