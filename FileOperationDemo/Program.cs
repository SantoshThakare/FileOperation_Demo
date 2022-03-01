using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileDemo file = new FileDemo();
            file.FileExists();
            file.ReadAllLines();
            file.ReadAllText();
        }
    }

}
