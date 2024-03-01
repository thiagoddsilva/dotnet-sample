using System.Text;

namespace DotnetSample;

public static class ReadFile
{

    public static string Read(string fileName)
    {
        var fileRead = File.OpenRead("test.txt");
        byte[] b = new byte[1024];
        UTF8Encoding temp = new UTF8Encoding(true);

        var result = new StringBuilder();
        while (fileRead.Read(b,0,b.Length) > 0)
        {
            result.Append(temp.GetString(b));
        }

        return result.ToString();
    }
}