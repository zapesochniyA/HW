// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int A = 3;
int B = 5;
int i = 0;
int res = 0;

while (i<=B)
{
    res = (int) Math.Pow(A, i);
    i++;
}

Console.WriteLine(res);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = 345;
int result = 0; 

for (int j = 0; j < num.ToString().Length; j++)
{
    result += int.Parse(num.ToString()[j].ToString());
}
Console.WriteLine("сумма чисел: " + result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

List<int> list = new List<int>(){1,2,7,9,40};
foreach (int j in list) {
    Console.WriteLine(j);
}
