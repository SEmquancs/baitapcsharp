using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh4
{
    class bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số nguyên dương n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhập số phần tử của mảng A({i}) = ");
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Mảng bạn đã nhập là:");
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i]+ " ");
            }
            
            int max = mang[0];
            int min = mang[0];
            for (int i = 0; i < mang.Length; i++)
            {
                if (max < mang[i])
                {
                    max = mang[i];
                }
                if (min > mang[i])
                {
                    min = mang[i];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Giá trị lớn nhất trong mảng: " + max);
            Console.WriteLine("Giá trị nhỏ nhất trong mảng: " + min);
            Console.WriteLine();
        }
    }
}
