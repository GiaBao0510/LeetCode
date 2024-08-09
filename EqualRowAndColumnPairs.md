[2352. Equal Row and Column Pairs](https://leetcode.com/problems/equal-row-and-column-pairs/)

Given a **0-indexed** `n x n` integer matrix `grid`, _return the number of pairs_ `(ri, cj)` _such that row_ `ri` _and column_ `cj` _are equal_.

A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).

**Example 1:**

![](https://assets.leetcode.com/uploads/2022/06/01/ex1.jpg)

**Input:** grid = [[3,2,1],[1,7,6],[2,7,7]]
**Output:** 1
**Explanation:** There is 1 equal row and column pair:
- (Row 2, Column 1): [2,7,7]

**Example 2:**

![](https://assets.leetcode.com/uploads/2022/06/01/ex2.jpg)

**Input:** grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
**Output:** 3
**Explanation:** There are 3 equal row and column pairs:
- (Row 0, Column 0): [3,1,2,2]
- (Row 2, Column 2): [2,4,2,2]
- (Row 3, Column 2): [2,4,2,2]

**Constraints:**

- `n == grid.length == grid[i].length`
- `1 <= n <= 200`
- `1 <= grid[i][j] <= 105`

## **Solution:**

```
public int EqualPairs(int[][] grid)
{
    int n = grid.Length;    // kích cỡ ma trận
    int equalPairs = 0;     //Số lượng cặp giống nhau
    Dictionary<string, int> rowCounts = new Dictionary<string, int>();  //Key là hàng, còn value là số lần xuất hiện

    //Duyệt trong hàng trước, để đếm hàng giống nhau
    foreach (var row in grid) {
        string Hang = string.Join(",", row);

        //Nếu mà tại key này không có giá trị trên thì đặt giá trị tại key đó là 0
        if (!rowCounts.ContainsKey(Hang))
            rowCounts[Hang] = 0;
        rowCounts[Hang]++;
    }

    //Kiểm tra cột và so sánh với hàng đã đếm
    for(int i = 0; i < n; i++)
    {
        //Lưu trữ các giá trị tại cột này vào column
        var column = new int[n];
        for (int j = 0; j < n; j++)
        {
            column[j] = grid[j][i];
        }

        //Tìm kiếm nếu có key này thì tăng thêm
        string ColumnString = string.Join(",", column);
        if (rowCounts.ContainsKey(ColumnString))
            equalPairs += rowCounts[ColumnString];
    }

    return equalPairs;
}
```