string[] array1 = 
{
    "q",
    "we",
    "rty",
    "asdf",
    "zxcvb",
    "Z"
};

string[] arrayIn = new string [array1.Length];
int sizeArrayIn = 0;

foreach (var item in array1)
{
    if (item.Length<=3)
    {
        arrayIn[sizeArrayIn] = item;
        sizeArrayIn ++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array1);
System.Console.WriteLine();
PrintArray(arrayIn);

// решение через обычный for

// void TakeLessThree (string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }

// решение через один массив (заполняем его только эллементами >=3)

// Console.Write("Сколько элементов Вы хотите ввести? ");
// int lengArr = Convert.ToInt32(Console.ReadLine());
// string[] arrayStrings = new string[lengArr];
// int len = 3;
// int pos = 0;
// for (int i = 0; i < lengArr; i ++)
// {
//  Console.WriteLine($"Введите {i+1}-й элемент: ");
//  string el1 = Convert.ToString(Console.ReadLine());     
//  if (el1.Length <= len)
//     {
//  arrayStrings[pos] = el1;
//  pos++;
//     }
// }
// Console.WriteLine();
// PrintArray(arrayStrings);