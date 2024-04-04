using System;
using System.IO;
class Save
{
    public static void SaveFunc(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.WriteLine($"\nO Arquivo {path} salvo com sucesso!!!");
        Console.ReadLine();
        Menu.MenuFunc();
    }
}
