using System;
using System.IO;

namespace OOP_lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("file1.txt");

            string str = fromFile.ReadToEnd();

            StreamWriter toFile = new StreamWriter("output.txt");

            toFile.WriteLine(str);

            fromFile = new StreamReader("file2.txt");

            str = fromFile.ReadToEnd();

            toFile.Write(str);

            toFile.Close();
        }
    }
}
