Given a binary array `nums`, you should delete one element from it.

Return _the size of the longest non-empty subarray containing only_ `1`_'s in the resulting array_. Return `0` if there is no such subarray.

**Example 1:**

**Input:** nums = [1,1,0,1]
**Output:** 3
**Explanation:** After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.

**Example 2:**

**Input:** nums = [0,1,1,1,0,1,1,0,1]
**Output:** 5
**Explanation:** After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].

**Example 3:**

**Input:** nums = [1,1,1]
**Output:** 2
**Explanation:** You must delete one element.

**Constraints:**

- `1 <= nums.length <= 105`
- `nums[i]` is either `0` or `1`.

## **Solution:**
```
public int LongestSubarray(int[] nums)
{
    int left = 0,          //Duyệt từ trái qua
          count_zero = 0,  //Đếm số lượng số 0 xuất hiện
          MaxLength = 0;   //Trả về chiều dài tối đa của 1 khi tìm được

    //Vòng lặp này duyệt phần tử từ đầu đến cuối
    for (int right = 0; right < nums.Length; right++) {
        //Nếu phần tử đang duyệt là 0 thì tăng biến count_zero lên 1 đơn vị
        if (nums[right] == 0)
        {
            count_zero++;
        }

	     //Khi mà biến count_zero > 1 thì duyệt chỉ số Left đang xét phía sau
        while (count_zero > 1)
        {
            if (nums[left] == 0)  //Nếu giá trị tại Left là 0 thì giảm giá trị biến count_zero đi 1 đơn vị
            {
                count_zero--;
            }
            left++;
          }

		//Lấy giá trị max giữa chính nó và right - left
        MaxLength = Math.Max(MaxLength, right - left);
    }
    Console.WriteLine("Output: {0}",MaxLength);
    return MaxLength; //Kết quả
}
```