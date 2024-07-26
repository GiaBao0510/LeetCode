Given a binary array `nums` and an integer `k`, return _the maximum number of consecutive_ `1`_'s in the array if you can flip at most_ `k` `0`'s.

**Example 1:**

**Input:** nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
**Output:** 6
**Explanation:** [1,1,1,0,0,**1**,1,1,1,1,**1**]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

**Example 2:**

**Input:** nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
**Output:** 10
**Explanation:** [0,0,1,1,**1**,**1**,1,1,1,**1**,1,1,0,0,0,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

**Constraints:**

- `1 <= nums.length <= 105`
- `nums[i]` is either `0` or `1`.
- `0 <= k <= nums.length`

## **Solution:**
```
public int LongestOnes(int[] nums, int k)
{
	int countNumber_0 = 0;  //Đếm số lượng số 0 .Nhưng phải <= K
	int MaximunNumber = 0;  //Số lượng đếm số 1 lớn nhất
	int L = 0, w;

	for(int R = 0; R < nums.Length; R++)
	{
		//Nếu phần tử đang duyệt mà == 0 ,thì đến số lượng số 0 lên
		if (nums[R] == 0) countNumber_0++;

		//Nếu trong trường hợp mà số lượng số 0 > k, thì thực hiện, giảm đếm số  lượng số 0 xuống
		while (countNumber_0 > k)
		{
			//Nếu phần tại chỗ phân tử L đang xét là 0, thì thực hiện giảm số lần đếm số 0 xuống
			if (nums[L] == 0) countNumber_0--;
			L++;    //Tăng chỉ số để duyệt
		}

		w = R - L + 1;

		//Tìm giá trị lơn nhất
		MaximunNumber = Math.Max(MaximunNumber, w);
	}


	 Console.WriteLine(MaximunNumber);
	//Trả về chuỗi số 1 tối đa khi tìm được
	return MaximunNumber;
}
```