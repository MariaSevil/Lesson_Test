
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] originalArray = { "Hello", "2", "world", ":-)" };
string[] newArray = new string[originalArray.Length];
int count = 0;

for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3) // проверить длину строки
    {
        newArray[count] = originalArray[i]; // добавить строку в новый массив
        count++; // увеличить переменную count
    }
}

Array.Resize(ref newArray, count); // изменить размер нового массива до нужной длины

for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]); //вывести каждую строку в новый массив
}


