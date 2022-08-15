/* Напишите программу, которая выводит третью цифру заданного числа  или сообщает, что третьей цифры нет.*/

Console.WriteLine ("Введите число: ");
int num = int.Parse (Console.ReadLine());
string treeNum = Convert.ToString (num);

if (treeNum.Length > 2)
{
    Console.WriteLine ("Третья цифра: "+ treeNum [2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет!");
}
