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

int SummOddNumbers(int[] arr) //Возвращает сумму эл-ов на нечетных позициях в принимаемом массиве
 {
    int i = 0;
    int sum = 0;
    while(i < arr.Length)
    {
        if(i%2 != 0) { sum += arr[i]; } i++;
    }
    return sum;
 }

string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
int[] collect = CreateArray(10,-10, 10);
int sum = SummOddNumbers(collect);
emptyString(3);
Console.WriteLine(text);
Console.WriteLine("    Задача 2");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Задайте одномерный массив, заполнен-\r\nный случайными числами. Найдите сумму\r\nэлементов, стоящих на нечётных позициях.");
Console.WriteLine(text);
PrintArray(collect);
Console.WriteLine($"Сумма элеметов на четных позициях = {sum}");
emptyString(1);
Console.WriteLine(text);
emptyString(2);