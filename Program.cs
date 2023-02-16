using System;
using System.IO;
using System.Text;

namespace FileCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string path = @"my_file.txt";
        // The line below will create a text file, my_file.txt in this program root
        using (StreamWriter sw = File.CreateText(path));

        // OR if you want add straight text (You dont need above..) ->

        // write text in file
        var writeText = "File content test 16-2-2023";
        File.WriteAllText(@"my_file.txt", writeText);    
        }
    }
}









        