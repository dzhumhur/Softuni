using System;
using System.Text;
class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.ASCII;
        char asciiTable = (char)0;
        byte charNum = 0;
        
        for (asciiTable = (char)0; asciiTable <= 255; asciiTable++)
        {
            Console.WriteLine("\"{0}\" - the char number in ASCII Table is - {1}", asciiTable, charNum++);
        }
    }
} 