/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] NewArray(int len) //функция для вывода массива случайных чисел
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10); 
    }
    return array;
}

void PrintArray(int[] array) //функция вывода на экран 
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write($"{array[i]}\t");
	}
	System.Console.WriteLine();
}

int[] arrey = NewArray(4); 
PrintArray(arrey);

int SumNumbNegPosition (int number)
{
	int sum = 0;
    int count = 1;
	while (count < arrey.Length)
	{
		sum = sum + arrey[count];
        count = count + 2;
	}
	return sum;
}

int sum = 0;
int sumnumb = SumNumbNegPosition(sum);
Console.Write($"сумма элементов, стоящих на нечётных позициях равна {sumnumb}");

