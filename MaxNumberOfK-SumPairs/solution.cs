using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            int operation = 0; //Số lần thao tác

            //Tạo 1 từ điển để lưu trữ gia trị sau khi trừ cho K
            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach(int i in nums)
            {
                int result = k - i;
                Console.WriteLine($" -- \t Duyet: {i}  - Result: {result}");

                //Nếu tìm thấy đã bị trừ so với giá trị đang xét với K thì tăng 1 thao tác và đánh dấu đã duyệt 
                if(map.ContainsKey(result) && map[result] > 0){
                    Console.WriteLine($">> Co chua: {result} - Map[{result}] = {map[result]}");
                    operation++;
                    map[result]--;
                }
                else
                {
                    //Nếu mà không tìm thấy giá trị bị trừ có trong map, mà giá trị đang xét vẫn tồn tại thì đánh dấu chưa duyệt tại vị trí đó
                    if (map.ContainsKey(i))
                    {
                        Console.WriteLine($"Set: {i}");
                        map[i]++;
                    }
                    else
                    {
                        Console.WriteLine($"Add: {i}");
                        map.Add(i, 1);  //Ngược lại thì thêm giá trị đang duyệt đó vào từ điển
                    }
                }            
            }

            Console.WriteLine(operation);
            return operation;
        }

        static void Main(string[] args) {
            Solution ob = new Solution();
            ob.MaxOperations([3,5,2,1,3,4,6],7);
        }
    }
}
