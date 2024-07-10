// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом
// (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] CreateStringArray(int size)
{
   string[] stringArray = new string[size];
   Console.WriteLine("Enter words through the input");
   for (int i = 0; i < size; i++)
   {
      stringArray[i] = Console.ReadLine()!;
   }
   return stringArray;
}

void SortStringArray(string[] stringArray)
{
   int count = 0;
   for (int i = 0; i < stringArray.Length; i++)
      if (stringArray[i].Length < 4) count++;
   if (count > 0)
   {
      string[] newArray = new string[count];
      int j = 0;
      for (int i = 0; i < stringArray.Length; i++)
      {
         if (stringArray[i].Length < 4)
         {
            newArray[j] = stringArray[i];
            j++;
         }
      }
      Console.WriteLine($"Преобразованный массив: [{string.Join(" ", newArray)}]");
   }
   else Console.WriteLine("В первоначальном массиве все элементы длиннее 3-х символов");
}
// void PrintStringArray(string[] stringArray)
// {
//    Console.Write("[");
//    for (int i = 0; i < stringArray.Length - 1; i++)
//    {
//       Console.Write($"{stringArray[i]},\t");
//    }
//    Console.Write($"{stringArray[stringArray.Length - 1]}");
//    Console.WriteLine("]");
// }
// PrintStringArray(
   SortStringArray(
      CreateStringArray(5));