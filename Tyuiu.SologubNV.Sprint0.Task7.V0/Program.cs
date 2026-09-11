using Tyuiu.SologubNV.Sprint0.Task7.V0.Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Title = "Спринт #0 | Выполнил: Сологуб Н.В | ИБКСб-26-1";
        WriteLine("***************************************************************************");
        WriteLine("* Спринт #0                                                               *");
        WriteLine("* Тема: Создание Итогового решения по спринту                             *");
        WriteLine("* Задание #7                                                              *");
        WriteLine("* Вариант #0                                                              *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
        WriteLine("* Одинаковых массивов по длине.                                           *");
        WriteLine("*                                                                         *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");

        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
        WriteLine("Значение Элементов массива №1");
        for (int i = 0; i< arrayNums1.Length; i++)
        {
            Write(arrayNums1[i] + ", ");
        }

        WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
        WriteLine("Значение Элементов массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Write(arrayNums2[i] + ", ");
        }

        WriteLine();
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        if (arrayNums1.Length == arrayNums2.Length)
            {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
            WriteLine("Сумма элементов массива равна:");
            for (int i = 0; i< resultArray.Length; i++)
            {
                Write(resultArray[i] + ", ");
            }
        }
        else
        {
            WriteLine("Ошибка! Исходные данные имеют разное количество элементов");
        }
        ReadKey();
    }
}