using System.Text;

namespace Menu.Storage;

class FileReader
{
    public List<string> ReadFile(string path)
    {
        return File.ReadAllLines(path).ToList();
    }
}