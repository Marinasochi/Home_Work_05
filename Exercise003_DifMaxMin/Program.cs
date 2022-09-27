static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
 {
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
 }

void ArrayInput(double[] collect) //Заполнение массива вещественными числами с консоли
 {
    int index = 0;
    int length = collect.Length;
    while (index < length)
    {
        Console.Write("Введите число:  ");
        string text = Console.ReadLine();
            if (double.TryParse(text, out collect[index]))
                { Console.WriteLine($"Вы ввели {index + 1} элемент. ", collect[index]); index++; }
            else
                { Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); }
    }
 }

void PrintArray(double[] array) // вывод массива на консоль
 { 
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
 }

double MaxElement(double[] arr) // возвращает максимальный элемент массива
 {
    int i = 0;
    double max = arr[0];
    while(i < arr.Length) 
    { if(max < arr[i]) { max = arr[i];} i++; }
    return max;
 }

double MinElement(double[] mas) // возвращает минимальный элемент массива
 {
    int i = 0;
    double min = mas[0];
    while(i < mas.Length) 
    { if(min > mas[i]) { min = mas[i];} i++; }
    return min;
 }


string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
double[] massive = new double[10];
emptyString(3);
Console.WriteLine(text);
Console.WriteLine("    Задача 3");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Задайте массив вещественных чисел.\r\nНайдите разницу между максимальным и ми-\r\nнимальным элементами массива.");
Console.WriteLine(text);
ArrayInput(massive);
emptyString(1);
PrintArray(massive);
emptyString(1);
double maxmass = MaxElement(massive);
double minmass = MinElement(massive);
Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива: {maxmass} - {minmass} = {maxmass - minmass}");
emptyString(1);
Console.WriteLine(text);
emptyString(2);