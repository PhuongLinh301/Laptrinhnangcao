using System;

namespace CongBaSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            
            Console.Write("Nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());

            
            while (true)
            {
                try
                {
                    Console.Write("Nhập b: ");
                    b = int.Parse(Console.ReadLine());
                    break; 
                }
                catch
                {
                    Console.WriteLine("Nhập sai, vui lòng nhập lại!");
                }
            }

            
            bool k;
            while (true)
            {
                Console.Write("Nhập c: ");
                k = int.TryParse(Console.ReadLine(), out c);

                if (k == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai, vui lòng nhập lại!");
                }
            }

        
            int tong = a + b + c;
            Console.WriteLine($"\nKết quả: {a} + {b} + {c} = {a + b + c}");

            Console.ReadLine();
        }
    }
}

