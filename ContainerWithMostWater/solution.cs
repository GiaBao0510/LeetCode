using System;

namespace Test
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int L = 0,  //Bắt đầu từ vị trí đầu mảng
                R = height.Length - 1,  //Bắt đầu từ vị trí cuối hàng
                maximum = 0;    //Lưu trữ giá trị lượng nước chứa lơn nhất

            //Dùng vòng lặp để xét duyệt
            while(L < R)
            {
                //Nếu mà giá trị tại L < R || L == R thì tăng chỉ số tại L
                if (height[L] < height[R] || height[L] == height[R])
                {
                    //Tính tìm lượng nước lớn nhất
                    int amount = height[L]* (R-L);
                    if(amount > maximum)
                    {
                        maximum = amount;
                    }

                    L++;
                }

                //Nếu mà giá trị tại L >= R thì giảm chỉ số tại R
                if (height[L] > height[R])
                {
                    //Tính tìm lượng nước lớn nhất
                    int amount = height[R] * (R - L);
                    if (amount > maximum)
                    {
                        maximum = amount;
                    }
                    R--;
                }
            }
            Console.WriteLine(maximum);
            return maximum;
        }

        static void Main(string[] args) {
            Solution ob = new Solution();
            ob.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
        }
    }
}
