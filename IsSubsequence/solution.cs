using System;

namespace Test
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            //1.Kiểm tra điều kiện đầu vào
            // >1.1 .Nếu độ dài s là 0 thì trả về true
            if(s.Length == 0 && t.Length > 0)
            {
                return true;
            }
            // >1.2. Nếu độ dài t là 0 thì trả về false
            if(s.Length > 0 && t.Length == 0)
            {
                return false;
            }
            // >1.3 .Nếu cả 2 có dùng độ dài là 0 thì trả về true
            if(s.Length == 0 && t.Length == 0)
            {
                return true;
            }

            //Thực hiện xét duyệt
            int i=0,  //đại diện cho duyệt chuỗi s
                j=0;  //Đại diện cho duyệt chuỗi t

            string result = ""; //Tạo chuỗi rỗng lưu kết quả

            while(j < t.Length)
            {
                //Nếu 2 ký tự giống nhau thì lưu
                if (s[i] == t[j])
                {
                    result += t[j];

                    //Nếu i mà còn nhỏ hơn độ dài s thì tiếp tục tăng
                    if(i < s.Length -1)
                    {
                        i++;
                    }
                }
                j++; //Duyệt tiếp bên t
            }

            //Nếu 2 chuỗi giống nhau thì trả về true
            if (string.Compare(s, result) == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args) {
            Solution ob = new Solution();
            ob.IsSubsequence("b", "abc");
        }
    }
}