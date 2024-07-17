using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buo2
{
    class Program
    {
        public static int Binary_search(int[] A, int n, int key)
        { 
            int left = 0; 
            int right = n-1; 
            while (left <= right)
          {
            int mid = (left + right)/2; 
                if (A[mid] == key)
            return mid;
                if (key < A[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
        }
            return -1; 
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 4, 5, 6, 12, 2, 23, 4, 52, 16 };
            
            Console.Write("Nhap so n: ");
            //int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int kq = Binary_search(A, 10, x);
            if(kq != -1)
            {
                Console.WriteLine("Tai vi tri " + kq);
            }else
            {
                Console.WriteLine("Khong tim thay");
            }
            Console.ReadKey();
        }
    }
}
