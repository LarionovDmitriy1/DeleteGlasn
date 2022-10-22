Console.WriteLine("Введите строку");
string select = Console.ReadLine();
char[] a = select.ToCharArray();
char[] b = new char[] { 'a', 'e', 'i', 'o', 'u' };
    foreach (char glasn in b)
    {
        bool isupper = char.IsUpper(glasn);
        if (isupper == false)
        {
            select = select.Replace(glasn.ToString(), "");
        }
    }
Console.WriteLine();
Console.WriteLine(select);