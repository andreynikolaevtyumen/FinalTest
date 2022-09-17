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