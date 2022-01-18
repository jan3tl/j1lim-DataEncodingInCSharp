using System;

namespace j1lim_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char ch;
            ch = 'A';
            Console.WriteLine($"ch is storing the value: {ch}");

            int ch_decimal;
            ch_decimal = ch;
            Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            int toConvert;
            Console.Write("Enter an integer: ");
            toConvert = int.Parse(Console.ReadLine());

            char asChar;
            asChar = (char)toConvert;
            Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            char b;
            b = (char)('A' + 1);
            Console.WriteLine($"'A' + 1 = {b}");

            char x;
            x = (char)('Z' + 3 );
            Console.WriteLine($"'Z' + 3 = {x}");

            char y;
            y = (char)('F' - 5);
            Console.WriteLine($"'F' - 5 = {y}");

            char f;
            f = (char)('K' - 3);
            char g;
            g = (char)('h' - 3);
            char h;
            h = (char)('o' - 3);
            char i;
            i = (char)('r' - 3);
            char j;
            j = (char)('#' - 3);
            char k;
            k = (char)('Z' - 3);
            char m;
            m = (char)('u' - 3);
            char n;
            n = (char)('g' - 3);
            char o;
            o = (char)('$' - 3);
            Console.WriteLine("What is the result of shifting each character in the string 'Khoor#Zruog$' by -3?");
            Console.WriteLine($"'{f}{g}{h}{h}{i}{j}{k}{i}{m}{h}{n}{o}'");*/

            Cipher cipher;
            cipher = new Cipher(5);
            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encrypted message is '{encrypted}'.");

            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            Console.WriteLine($"The encrypted message is '{decrypted}'.");




        }
    }
}
