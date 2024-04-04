using System;
using System.Runtime.CompilerServices;
class Menu
{
    public static void MenuFunc()
    {
        Console.Clear();
        Console.WriteLine("Menu de Opções:");
        Console.WriteLine("1- Abrir arquivo.");
        Console.WriteLine("2- Criar um novo arquivo.");
        Console.WriteLine("3- Sair.");
        Console.Write("\nDigite uma opção: ");

        double option;
        while (!double.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
        {
            Console.WriteLine("\nOpção invalida. Porfavor digite uma opção ente (1/2/3).");
            Console.Write("\nDigite a opção novamente: ");
        }
        switch (option)
        {
            case 1: OpenFile.OpenFileFunc(); break;
            case 2: Editor.EditorFunc(); break;
            case 3: System.Environment.Exit(3); break;
            default: MenuFunc(); break;
        }
    }
}