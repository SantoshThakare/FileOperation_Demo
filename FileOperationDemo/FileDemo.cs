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
        public  void FileExists()
        {
            String path = @"E:\VSCode\BasicProgram\FileOperationDemo\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
        }
    }
}
