using System;
class Editor
{
    public static void EditorFunc()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
        Console.WriteLine("---------------------------------------");
        string text = "";
        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
        Save.SaveFunc(text);
    }
}