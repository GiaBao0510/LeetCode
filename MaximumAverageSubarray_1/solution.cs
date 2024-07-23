using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Test
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double maximumAverage = Double.NegativeInfinity;      //Trả về giá trị trung bình lớn nhất
            int ArrayLength = nums.Length;  //Độ dài mảng
            int sum = 0;                    //Tính tổng giá trị
            int L = 0;                      //Vị trí vế trái tăng khi i == k-1

            //Điều kiện trước khi bắt đầu là k <= độ dài mảng
            if(k <= ArrayLength)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    double totalAverage = 0;
                    sum+= nums[i];
                   
                    //Nếu i => K -1 thì ta thực hiện thao tác so sánh tìm trung bình tổng giá trị lớn nhất
                    if (i == k -1)
                    {
                        totalAverage = sum / (double)k; //Tính trung bình cộng

                       //Tìm giá trị trung bình cộng lớn nhất
                        if (totalAverage > maximumAverage) maximumAverage = totalAverage;

                    }
                    else if(i > k - 1)
                    {
                        sum -= nums[L];             //Trừ bỏ đi giá trị ở phần tử đẩu
                        
                        totalAverage = sum / (double)k;
                        //Tìm giá trị trung bình cộng lớn nhất
                        if (totalAverage > maximumAverage) maximumAverage = totalAverage;
                        L++;
                    }
                   
                }
            }

            return maximumAverage;
        }

        static void Main(string[] args) {
            Solution ob = new Solution();
            ob.FindMaxAverage([4, 0, 4, 3, 3], 5);
        }
    }
}
