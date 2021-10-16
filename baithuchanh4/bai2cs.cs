using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh4
{
    class bai2cs
    {
        static void InputAction(out int num)
        {
            Console.Write($"Nhập số n = ");
            num = Convert.ToInt32(Console.ReadLine());
            // co can gan gia tri cua n vo 1 cai gi ko xong duoi ms viet ra
        }    
        
        static void Main(string[] args)
        {
            int n = 0;            
            Console.OutputEncoding = Encoding.UTF8;
            InputAction(out n);
            //dc roi
            //debug la vay a
            //xemm cai gia tri o duoi kia
            //bua tao thu r ma co vai khuc no deo chay nua. chac do ko biet thao tac
            // quang breakpoint mau do ra
            // no chay dc vai dong xong co dong no ko chay dc nua
            // ccung cai bai nay luon ne bua debug toi cai nhap so n vo ko chay nua
            int[] mang = new int[n];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhập số phần tử của mang A([{i}] = ");
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            Console.WriteLine("Mảng bạn đã nhập là:");
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i]+ " ");
            }
            Console.WriteLine();

            int max = mang.Max();
            int min = mang.Min();
            if(max!=min)
            {
                Console.WriteLine("Giá trị lớn nhất mảng = " + max);
                Console.WriteLine("Gia tri bé nhất mảng = " + min);

            }else
                Console.WriteLine("Mảng không có giá trị lớn nhât, bé nhất");
            
            int max2 = mang.Min();
            int min2 = mang.Max();

            for (int i = 0; i < mang.Length; i++)
            {
                if (max2 < mang[i] && mang[i] != mang.Max())
                {
                    max2 = mang[i];
                }
                if (min2 > mang[i] && mang[i] != mang.Min())
                {
                    min2 = mang[i];
                }
            }
            // tu tu ti vo suaw lai t co viec chut
            if (min2 != max2)
            {
                Console.WriteLine("Giá trị lớn nhì mảng: " + max2);
                Console.WriteLine("Giá trị bé nhì mảng: " + min2);
            }
            else
            {
                Console.WriteLine("Không có giá trị nào thõa mãn lớn nhì mảng, bé nhì mảng");
            }                                                          
        }
    }
}
