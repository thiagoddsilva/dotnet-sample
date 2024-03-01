// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!!");

var fileRead = File.OpenRead("test.txt");
byte[] b = new byte[1024];
UTF8Encoding temp = new UTF8Encoding(true);

while (fileRead.Read(b,0,b.Length) > 0)
{
    Console.WriteLine(temp.GetString(b));
}