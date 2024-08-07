[1207. Unique Number of Occurrences](https://leetcode.com/problems/unique-number-of-occurrences/)

Given an array of integers `arr`, return `true` _if the number of occurrences of each value in the array is **unique** or_ `false` _otherwise_.

**Example 1:**

**Input:** arr = [1,2,2,1,1,3]
**Output:** true
**Explanation:** The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

**Example 2:**

**Input:** arr = [1,2]
**Output:** false

**Example 3:**

**Input:** arr = [-3,0,1,-3,1,1,1,-3,10,0]
**Output:** true

**Constraints:**

- `1 <= arr.length <= 1000`
- `-1000 <= arr[i] <= 1000`

## **Solution:**

```
public bool UniqueOccurrences(int[] arr)
{
    //Từ điển: Keys là giá trị và value là số lần xuất hiện
    Dictionary<int, int> TuDien = new Dictionary<int, int>();
    for(int i = 0; i < arr.Length; i++)
    {
        //Nếu phần keys có chứa thì tăng số lần xuất hiện, ngược lại thì tạo mới
        if (TuDien.ContainsKey(arr[i]))
        {
            TuDien[arr[i]]++;
        }
        else
        {
            TuDien[arr[i]]=1;
        }
    }

    //Tạp danh sách chứa số lần xuất hiện nếu mà đã có rồi thì trả về false
    List<int> countList = new List<int>();
    foreach (var i in TuDien)
    {
        if (countList.Contains(i.Value)) return false;
        countList.Add(i.Value);
    }

    return true;
}
```