using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    internal class Program
    {
        //StringBuilder is a mutable class (change can happen at the same memory location)
        //We need add System.Text namespace

        static void Main(string[] args)
        {
            StringBuilder sb=new StringBuilder("Hello");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity"+sb.Capacity);
            Console.WriteLine("Length"+sb.Length);

            //sb.Remove(2, 2);
            //Console.WriteLine(sb);
            //Console.WriteLine("Capacity" + sb.Capacity);
            //Console.WriteLine("Length" + sb.Length);

            //sb.Clear();
            //Console.WriteLine(sb);
            //Console.WriteLine("Capacity" + sb.Capacity);
            //Console.WriteLine("Length" + sb.Length);

            sb.Append(" Good morning");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity" + sb.Capacity);
            Console.WriteLine("Length" + sb.Length);

            sb.Append(" All ");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity" + sb.Capacity);
            Console.WriteLine("Length" + sb.Length);

            //sb.Remove(2, 2);
            //Console.WriteLine(sb);
            //Console.WriteLine("Capacity" + sb.Capacity);
            //Console.WriteLine("Length" + sb.Length);

            sb.Replace("All", "Everyone");
            Console.WriteLine(sb);
            Console.WriteLine("Capacity" + sb.Capacity);
            Console.WriteLine("Length" + sb.Length);

            //copy 
            char[] ch2 = new char[5];
            sb.CopyTo(1,ch2,0,5);
            string str1=string.Join(" ",ch2);
            Console.WriteLine(str1);


        }
    }
}
