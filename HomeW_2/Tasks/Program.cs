/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1*/

/*Console.WriteLine("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int numberMin = 100;
int numberMax = 1000;
int secondNumb = 0;
int lastDigit = 0;

if (inputNumber > numberMin && inputNumber < numberMax)
{
    secondNumb = inputNumber / 10;
    lastDigit = secondNumb % 10;
}

else
{
    Console.Write("Incorrect number ");
}

Console.WriteLine(lastDigit);*/

Console.WriteLine("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int numberMin = 100;
int numberMax = 1000;
int secondNumb = inputNumber / 10;
int lastDigit = secondNumb % 10;

if (inputNumber >= numberMin && inputNumber < numberMax)
{
    Console.WriteLine(lastDigit);
}

else
{
    Console.Write("Incorrect number ");
}


/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет*/

/*Console.WriteLine("Введите день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

   if (Day < 8 && Day > 5)
    {
    Console.Write("Yes");
    }
else if (Day >=1 && Day < 6)

    {
    Console.Write("No");
    }
else
{
    Console.WriteLine ("Вы ввели не день недели");
}*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1000 )
{
    number = number / 10;
    
}

if (number < 1000 && number >= 100)
{
    number = number % 10;
    Console.WriteLine(number);
}
else if ( number < 100)
{
    Console.Write("Третьей цифры нет");
}*/
