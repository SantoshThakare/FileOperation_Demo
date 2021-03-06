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
        public void FileCopy()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";
            String copypath = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample1.txt";

            File.Copy(path, copypath);

        }
        public  void DeleteFile()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample1.txt";

            File.Delete(path);

        }
        public void ReadFromStreamReader()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
        public void WriteUsingStreamWriter()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperation_Demo\FileOperationDemo\Sample.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\n Hellow World - .Net is awesome1");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
