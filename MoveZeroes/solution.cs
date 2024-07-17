public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        
        int[] result = new int[nums.Length];    // Mảng kết quả
        int index = 0;                          //Vị trí nhận giá trị

        //Đếm số lần xuất hiện số 0 trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            //Nếu phần tử đang duyệt khác 0 thì thêm vào mảng
            if (nums[i] != 0)
            {
                result[index] = nums[i];
                index++;
            } 
        }

        //Thêm các phần tư 0 vào cuối mảng
        for(int i = index; i < nums.Length; i++)
        {
            result[i] = 0;
        }

        //Sao chép mảng
        Array.Copy(result, nums, nums.Length);

        //hiển thị
        Console.WriteLine("[{0}]", string.Join(",", nums));
    }

        void Main(string[] args) {

        Solution ob = new Solution();
        ob.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
    }
}