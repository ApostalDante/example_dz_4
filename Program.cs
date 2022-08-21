/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵)
 2, 4 -> 16
*/

/* - решение - */

Console.Clear();

int Exponentiation(int number, int degreeNumber)
{
    int result = 1;
    for (int i = 1; i <= degreeNumber; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень числа {number}: ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(number, degreeNumber);
Console.WriteLine("Результат: " + exponentiation);


/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

/* - решение - */

Console.Clear();

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

/* - решение - */

Console.Clear();

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();


seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки


// функция удаления пробелов из строки 
string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}


// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{

    int[] arrayOfNumbers = new int[1];

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
        }
        j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
