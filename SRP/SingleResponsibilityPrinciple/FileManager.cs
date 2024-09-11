namespace SingleResponsibilityPrinciple;
public class FileManager 
{
    public void SaveToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string LoadFromFile(string filename)
    {
        return File.ReadAllText(filename);
    }
}