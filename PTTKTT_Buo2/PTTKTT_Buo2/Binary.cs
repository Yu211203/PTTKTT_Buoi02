using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buo2
{
    public class Binary
    {
        public int Binary_search(int[] A, int n, int key)
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
    }
}
