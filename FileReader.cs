class FileReader
{
    public List<string> ReadFile(string path)
    {
        return File.ReadAllLines(path).ToList();
    }
}