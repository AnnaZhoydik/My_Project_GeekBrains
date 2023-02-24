string[] array = { "number", "im", "String", "ok", "!" };
for (int i = 0; i < array.Length; i++)
{
    char[] a = array[i].ToCharArray();
    char[] b = a.ToArray();
    if (array[i].Length < 3)
        Console.Write($"{array[i]} ");
}