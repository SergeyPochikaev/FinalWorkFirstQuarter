// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void InputCondition()
{
  Console.Clear();
  Console.WriteLine("----------------------------------------------------------\n" +
                    "Запишите любое количество различных символов через пробел!\n" +
                     "----------------------------------------------------------");
}

// Метод определения значения элементов из символов менее 3
string GetArrayLessThree(string[] array)
{
  string result = String.Empty;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      result += $"{array[i]}, ";
    }
  }
  if (result.Length > 0)
  {
    result = result.Substring(0, result.Length - 2);
    return result;
  }
  else return result;
}

// Метод распечатки
string GoodPrint(string[] arrayInt, string stringInt)
{
  return $"[{String.Join(",", arrayInt)}] -> [{stringInt}]";
}

InputCondition();
string[] characters = Console.ReadLine()!
                             .Split(' ');
Console.Write(GoodPrint(characters, GetArrayLessThree(characters)));