using System;

namespace LerIni
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Your Path!";
            IniFile iniFile = new IniFile(path);

            string keyValue = iniFile.ReadValue("[SECTION]", "KEY");

            Console.WriteLine($"Value: {keyValue}");
        }
    }
}
