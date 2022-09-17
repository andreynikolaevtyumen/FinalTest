string[] array = new string[] { "hello", "2", "world", ";-)", "!!!", "maximum" };
string[] newarray = new string[array.Length];
int n = 0;

void CheckArray()
{
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            newarray[n] = array[i];
            n++;
        }
    }
}

void PrintSolution()
{
    Console.Clear();
    Console.WriteLine("Формируем из имеющегося массива строк новый массив из строк, длина которых меньше или равна 3 символам: ");
    Console.WriteLine();
    newarray = newarray.Where(x => x != null).ToArray();
    Console.Write("[{0}] ---> ", string.Join(", ", array));
    Console.WriteLine("[{0}]", string.Join(", ", newarray));
    Console.WriteLine("");
}

CheckArray();
PrintSolution();