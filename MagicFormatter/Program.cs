using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        string input = Clipboard.GetText();

        foreach (string line in input.Split('\n'))
        {
            Console.WriteLine(line.Split(" - ")[0].Trim());
        }

        Console.ReadKey();
    }
}