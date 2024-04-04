using System;
using System.IO;
class OpenFile
{
    public static void OpenFileFunc()
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            var text = file.ReadToEnd();
            Console.WriteLine(text);
        }
        Console.WriteLine("\n");
        Console.ReadLine();
        Menu.MenuFunc();
    }
}