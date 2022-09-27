static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
 {
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
 }

int[] CreateArray(int length, int min, int max) // генерирует массив случайных целых чисел в принимаемом диапазоне
 {
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
 }

void PrintArray(int[] array) // вывод массива на консоль
 { 
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
 }

int CountEvenNumbers(int[] arr) //Возвращает количество четных чисел в массиве
 {
    int i = 0;
    int count = 0;
    while(i < arr.Length)
    {
        if(arr[i]%2 == 0) { count += 1; } i++;
    }
    return count;
 }

string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
int[] collect = CreateArray(8,100, 999);
int sum = CountEvenNumbers(collect);
emptyString(3);
Console.WriteLine(text);
Console.WriteLine("    Задача 1");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Задайте массив заполненный случайными\r\nположительными трёхзначными числами. На-\r\nпишите программу, которая покажет коли-\r\nчество чётных чисел в массиве.");
Console.WriteLine(text);
PrintArray(collect);
Console.WriteLine($"Количество четных элеметов в массиве = {sum}");
emptyString(1);
Console.WriteLine(text);
emptyString(2);
