// See https://aka.ms/new-console-template for more information

int[] myArray = { 2, 5, 6, 43, 2, 5 };
Console.WriteLine(myArray[^1]);//последний элемент массив

int[] myArray2 = myArray[1..4];//диапозон
int[] myArray3 = myArray[5..];
string helo = "ихихихихихих ахахаххахаха привет";
Console.WriteLine(helo[^2..]);
Console.WriteLine(helo[1..8]);
foreach (var item in myArray[..5])
{
    Console.Write(item);
}