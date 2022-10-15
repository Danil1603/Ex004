/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string numberA = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string numberB = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string numberC = Console.ReadLine();

int NumberInt1 = int.Parse(numberA);
int NumberInt2 = int.Parse(numberB);
int NumberInt3 = int.Parse(numberC);

int max = NumberInt1;
if(max < NumberInt2)
{
    max = NumberInt2;
}
if(max < NumberInt3)
{
    max = NumberInt3;
}

Console.WriteLine($"Максимальное число {max}");
