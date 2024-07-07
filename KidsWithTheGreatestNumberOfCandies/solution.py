class Solution(object):
    def kidsWithCandies(self, candies, extraCandies):

        #Cộng số lượng kẹo hiện có vs số lượng hiện tại
        numbers = [x + extraCandies for x in candies]

        #Lấy số lượng lớn nhất từ số lượng cũ
        largestNum = max(candies)

        #Duyệt điều kiện
        result = [x >= largestNum for x in numbers]
        return result

candies =[4,2,1,1,2] ; extraCandies =1
ret = Solution().kidsWithCandies(candies, extraCandies)
print(ret)
Solution().kidsWithCandies(candies, extraCandies)