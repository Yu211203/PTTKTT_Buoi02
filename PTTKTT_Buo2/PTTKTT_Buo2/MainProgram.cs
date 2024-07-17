using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buo2
{
    class MainProgram
    {
        public static void Main(string[] args)
        {

            //BinarySearch

            Binary bn = new Binary();
            int[] A = { 1, 4, 5, 6, 12, 2, 23, 4, 52, 16 };
            Console.WriteLine("Binary Search");
            Console.Write("Nhap so n: ");
            //int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int kq = bn.Binary_search(A, 10, x);
            if (kq != -1)
            {
                Console.WriteLine("Tai vi tri " + kq);
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
            

            //Nhan Hai So Nguyen Lon

            Console.WriteLine("NHAN HAI SO NGUYEN LON");
            string num1 = "23099519";
            Console.WriteLine("Num1: "+num1);
            
            string num2 = "21120302";
            Console.WriteLine("Num2: " + num2);
            NhanHaiSoNguyenLon ns = new NhanHaiSoNguyenLon();

            string result = ns.Multiply(num1, num2);

            Console.WriteLine("Ket qua = " + result);

            Console.ReadKey();
        }
    }
}
