using System.IO;

namespace OceanMotion;

public static class Program
{
    static void Main(String[] args) {
        FileHandler fh = new FileHandler();
        Console.WriteLine(fh.ValidateFile(".\\testData1.txt", 10, 0, 2, 0.0001));
    }
}
