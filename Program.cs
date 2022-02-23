string[] StartArray = {"hello", "2", "world", ":-)"};

void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"\"{array[i]}\"");
		if (i < array.Length - 1) Console.Write(",");
	}
	Console.Write("]");
}

string[] CreatNewArray(string[] array)
{
	int sizeNewArray = 0;
	string[] NewArray = new string[sizeNewArray];
    int j = 0;
	for (int i = 0; i < StartArray.Length - 1; i++)
	{
		if (StartArray[i].Length <= 3)
		{
			NewArray[j] = StartArray[i];
			sizeNewArray++;
			j++;
		}
	}
	return NewArray;
}


PrintArray(StartArray);
string[] NewArray = CreatNewArray(StartArray);
Console.Write(" -> ");
PrintArray(NewArray);