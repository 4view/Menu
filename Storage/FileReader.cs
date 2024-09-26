using System.Text;

namespace Menu.Storage;

/// <summary>
/// Class that read file 
/// </summary>
class FileReader
{
    public List<string> ReadFile(string path)
    {
        return File.ReadAllLines(path).ToList();
    }
}