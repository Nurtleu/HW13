using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace File1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num;
            using (FileStream stream = new FileStream(@"C:\FileSystem\FibonacciNumber.txt", FileMode.Create))
            {
                string fibNumber = "0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765";
                byte[] bytes = System.Text.Encoding.Default.GetBytes(fibNumber);
                stream.Write(bytes, 0, bytes.Length);
            }
            using (FileStream fstream =new FileStream(@"C:\FileSystem\FibonacciNumber.txt",FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[fstream.Length];
                fstream.Read(bytes, 0, bytes.Length);
                string num = Encoding.Default.GetString(bytes);
                string[] numbers = num.Split(' ');
                WriteLine("Файл успешо записан!");
            }
            using (FileStream istream = new FileStream(@"C:\FileSystem\Input.txt", FileMode.Create))
            {
                string Sum = "50 20";
                byte[] bytes = System.Text.Encoding.Default.GetBytes(Sum);
                istream.Write(bytes, 0, bytes.Length);
            }
            using (FileStream istream = new FileStream(@"C:\FileSystem\Input.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[istream.Length];
                istream.Read(bytes, 0, bytes.Length);
                string num = Encoding.Default.GetString(bytes);
                string[] numbers = num.Split(' ');
                Num = (Int32.Parse(numbers[0]) + Int32.Parse(numbers[1])).ToString();
                WriteLine("{0}+{1}={2}", numbers[0], numbers[1], Num);
                WriteLine("Файл успешо записан!");
            }
            using (FileStream iostream = new FileStream(@"C:\FileSystem\Output.txt",FileMode.Create))
            {
                string Secondsum = "50 20";
                byte[] bytes = System.Text.Encoding.Default.GetBytes(Secondsum);
                iostream.Write(bytes, 0, bytes.Length);
            }
            using (FileStream ifstream = new FileStream(@"C:\FileSystem\Output.txt", FileMode.OpenOrCreate))
            {
                byte[] Secondbytes = new byte[ifstream.Length];
                ifstream.Read(Secondbytes, 0, Secondbytes.Length);
                string num = Encoding.Default.GetString(Secondbytes);
                string[] Secondnumbers = num.Split(' ');
                Num = (Int32.Parse(Secondnumbers[0]) - Int32.Parse(Secondnumbers[1])).ToString();
                WriteLine("{0}-{1}={2}", Secondnumbers[0], Secondnumbers[1], Num);
                WriteLine("Файл успешо записан!");
            }
            ReadLine();
        }
    }
}
