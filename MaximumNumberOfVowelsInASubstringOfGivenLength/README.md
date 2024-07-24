[1456. Maximum Number of Vowels in a Substring of Given Length](https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/)

Given a string `s` and an integer `k`, return _the maximum number of vowel letters in any substring of_ `s` _with length_ `k`.

**Vowel letters** in English are `'a'`, `'e'`, `'i'`, `'o'`, and `'u'`.

**Example 1:**

**Input:** s = "abciiidef", k = 3
**Output:** 3
**Explanation:** The substring "iii" contains 3 vowel letters.

**Example 2:**

**Input:** s = "aeiou", k = 2
**Output:** 2
**Explanation:** Any substring of length 2 contains 2 vowels.

**Example 3:**

**Input:** s = "leetcode", k = 3
**Output:** 2
**Explanation:** "lee", "eet" and "ode" contain 2 vowels.

**Constraints:**

- `1 <= s.length <= 105`
- `s` consists of lowercase English letters.
- `1 <= k <= s.length`

## **Solution:**

```
public class Solution
{
    public int MaxVowels(string s, int k)
    {
        int MaxNumVowel = 0,            //Lấy số lượng số nguyên âm xuất hiện nhiều nhất trong chuỗi con có kích cỡ là K
            CountVowelLetter = 0;       //Dùng để đếm số nguyên âm trong chuỗi con có kích cỡ == k

        //Mảng chữ cái nguyên âm
        HashSet<char> Vowels = new HashSet<char>{'u', 'e', 'a', 'i', 'o' };

        //Duyệt từng ký tự từ 0 đến k -1
        for (int i = 0; i < k && i < s.Length ; i++)
        {
            //Nếu mà ký tự đang xét là số nguyên âm thì đếm tăng lên
            if (Vowels.Contains(s[i]))
            {
                CountVowelLetter++;
            }
        }

        MaxNumVowel = CountVowelLetter;

        //Duyệt từng kỳ tự từ K đến s.length-1
        for (int i = k; i < s.Length; i++)
        {
            
            //Nếu ký tự phía trước kia mà là số nguyên âm thì giảm
            int L = i - k;
            if (Vowels.Contains(s[L]))
            {
                CountVowelLetter--;
            }

            //Nếu mà ký tự đang xét là số nguyên âm thì đếm tăng lên
            if (Vowels.Contains(s[i]))
            {
                CountVowelLetter++;
            }

            MaxNumVowel = Math.Max(MaxNumVowel, CountVowelLetter);
        }


        return MaxNumVowel;
    }
```