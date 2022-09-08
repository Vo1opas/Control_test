/// Написать программу, которая из имеющегося массива строк формирует массив из строк,
/// длинна которых меньше или равна 3 символа.








string[] array = { "lol", "pervii", "vtoroi", "asd", "eshe" };

string[] newArray = new string[array.Length];
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[counter] = array[i];
        counter++;
    }

}

Console.WriteLine("Элументы в которых меньше или ровно 3 символа: ");

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
