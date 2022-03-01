using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationDemo
{
    public class FileDemo
    {
        public void FileExists()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
                Console.WriteLine("File doesn't exists");
        }
        public void ReadAllLines()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";
            String[] lines;

            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }
        public void ReadAllText()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

        }
    }
}
