using System.IO;
using System;

public static class test
{
    static void Main(String[] args) {
        string path = ".\\testText.txt";
        StreamReader sr = new StreamReader(path);
        string line1 = sr.ReadLine();
        while (line1 != null) {
            Console.WriteLine(line1);
            line1 = sr.ReadLine();
        }
        sr.DiscardBufferedData();
        line1 = sr.ReadLine();
        while (line1 != null) {
            Console.WriteLine("test");
            line1 = sr.ReadLine();
        }
        Console.WriteLine("Finished");
        sr.Close();
    }
}