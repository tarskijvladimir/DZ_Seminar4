/* Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
 Напишите программу, которая задает массив из N элементов в заданном пользователем диапазоне и выводит их на экран.
1,2,5,7,19 -> [1,2,5,7,19]
6,1,33 -> [6,1,33]*/


// Console.WriteLine("введите 8 чисел ");
// int[] array = new int[8]; 

//         for (int i = 0; i < 8; i++)
//         {
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
//             Console.WriteLine("____________");
//             Console.Write("[ ");

//         for (int i = 0; i < 8; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.Write("]");



void Mass(int n)
{
    int[] array = new int[n];  // создаем массив на необходимое количество элементов
        
    for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
            Console.WriteLine("____________");
            Console.Write("[ ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write("]");
}
   Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // получаем длинну
Console.WriteLine("введите числа ");
Mass(n); 

