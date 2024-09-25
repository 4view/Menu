using System.Buffers.Text;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Unicode;
using Microsoft.VisualBasic;

namespace Menu.Storage;

class FileWriter
{
    public void WriteDish(string path)
    {
        Console.WriteLine("Enter a new dish: ");
        var newDish = Console.ReadLine();

        File.AppendAllText(path, newDish + "\n");
    }
}