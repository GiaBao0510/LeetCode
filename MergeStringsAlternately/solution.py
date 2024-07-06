class Solution(object):

    def mergeAlternately(self, word1, word2):
        merge = ""
        #Tìm chuỗi có độ dài nhỏ nhất mà lấy
        for i in range(min(len(word1), len(word2))):
            merge += word1[i] + word2[i]

        #Lấy phần dư
        return str(merge + word1[i+1:] + word2[i+1:]).strip()
        
word1 = input("Nhập 1:") ;word2 = input("Nhập 2:")
ret = Solution().mergeAlternately(word1,word2)
print(ret)
Solution().mergeAlternately(word1,word2)