[1657. Determine if Two Strings Are Close](https://leetcode.com/problems/determine-if-two-strings-are-close/)

Two strings are considered **close** if you can attain one from the other using the following operations:

- Operation 1: Swap any two **existing** characters.
    - For example, `abcde -> aecdb`
- Operation 2: Transform **every** occurrence of one **existing** character into another **existing** character, and do the same with the other character.
    - For example, `aacabb -> bbcbaa` (all `a`'s turn into `b`'s, and all `b`'s turn into `a`'s)

You can use the operations on either string as many times as necessary.

Given two strings, `word1` and `word2`, return `true` _if_ `word1` _and_ `word2` _are **close**, and_ `false` _otherwise._

**Example 1:**

**Input:** word1 = "abc", word2 = "bca"
**Output:** true
**Explanation:** You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -> "acb"
Apply Operation 1: "acb" -> "bca"

**Example 2:**

**Input:** word1 = "a", word2 = "aa"
**Output:** false
**Explanation:** It is impossible to attain word2 from word1, or vice versa, in any number of operations.

**Example 3:**

**Input:** word1 = "cabbba", word2 = "abbccc"
**Output:** true
**Explanation:** You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -> "caabbb"
Apply Operation 2: "caabbb" -> "baaccc"
Apply Operation 2: "baaccc" -> "abbccc"

**Constraints:**

- `1 <= word1.length, word2.length <= 105`
- `word1` and `word2` contain only lowercase English letters.

## **Solution:**

```
public bool CloseStrings(string word1, string word2)
{
    //Nếu độ dài 2 chuỗi khác nhau thì trả về null
    if(word1.Length != word2.Length) return false;

    //Tạo 2 mảng có kích cỡ là 26 vì tiếng anh có 26 ký tự
    int[] count1 = new int[26];
    int [] count2 = new int[26];

    //Lấy ký từ so sánh trừ cho 'a' để lấy thông tin vị trí xuất hiện. Nếu tồn tại thì tăng lên 1 đơn vị
    foreach (char c in word1)
        count1[c - 'a']++;

    foreach (char c in word2)
        count2[c - 'a']++;

    //So sánh sự xuất hiện ký tự của 2 mảng trên. Nếu mà vị trí nào đó có ký tự xuất hiện bên này mà bên kia không xuất hiện thì false
    for (int i = 0; i< 26;i++)
    {
        if ((count1[i] == 0) != (count2[i] == 0)) return false;
    }

    //Sắp xếp lại 2 mảng trên
    Array.Sort(count1);
    Array.Sort(count2);

    //So sánh từng cặp giá trị của 2 mảng .nếu cặp giá trị đó không trùng nhau thì trả về false, ngược lại trả về true
    return Enumerable.SequenceEqual(count2, count1);
}
```