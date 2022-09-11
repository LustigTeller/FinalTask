/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
*/


string[] array = new string[7] { "hello", "2", "world", ":-)", "1567", "Kazan", "123" };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}
string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
Console.Write("[" + string.Join(", ", newArray) + "]");
